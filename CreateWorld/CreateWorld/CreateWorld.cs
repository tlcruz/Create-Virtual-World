using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.IO;
using System.Reflection;
using Viewer;
using VRLibrary.Stimulus;
using VRLibrary.Stimulus.Subsystems;
using VRLibrary.Stimulus.Services;
using VRLibrary.Stimulus.ServiceFactories;

namespace CreateWorld
{
    public partial class CreateWorld : Form
    {
        public Game1 game;
        /* Object build the models to .XNB format */
        public ContentBuilder contentBuilder;
        public WorldObject camera;
        public CreateWorld()
        {
            contentBuilder = new ContentBuilder();
            InitializeComponent();
        }

        /* When the Add button is pressed */
        private void AddObject_Click(object sender, EventArgs e)
        {
            ObjectList.TopNode.Tag = game.root;
            if (this.game.root.GetWorldObject("Fly") == null)
            {
                //SelectCameraFirst selCam = new SelectCameraFirst();
                //selCam.ShowDialog();
            }
            else
            {
                /* If no node is selected as to select one first */
                if (this.ObjectList.SelectedNode == null)
                {
                    //SelectObject selectObject = new SelectObject();
                    //selectObject.ShowDialog();
                }
                /* In the other case start the Object Editor */
                else
                {
                    ObjectEditor objEditor = new ObjectEditor(this);
                    objEditor.ShowDialog();
                }
            }
        }

        /* When the Remove button is pressed remove the selected node */
        private void RemoveObject_Click(object sender, EventArgs e)
        {
            RenderSubsystem renderSubsystem = (RenderSubsystem)this.game.Services.GetService(typeof(RenderSubsystem));
            UpdateSubsystem updateSubsystem = (UpdateSubsystem)this.game.Services.GetService(typeof(UpdateSubsystem));

            if (this.ObjectList.SelectedNode != this.ObjectList.TopNode)
            {
                WorldObject obj = (WorldObject)this.ObjectList.SelectedNode.Tag;
                NameService name = (NameService)obj.GetService(typeof(NameService));
                if (name.name != "Fly")
                {
                    if (renderSubsystem.DrawServices.ContainsKey(name.ObjectName()))
                    {
                        renderSubsystem.DrawServices.Remove(name.ObjectName());
                    }
                    RemoveParent(this.ObjectList.SelectedNode, this.ObjectList.SelectedNode.Parent);
                }
                this.ObjectList.SelectedNode.Remove();
            }
        }

        /* Remove a World Object from the World Object list of its parent */
        public void RemoveParent(TreeNode node, TreeNode parentNode)
        {
            WorldObject worldObj = (WorldObject)parentNode.Tag;
            WorldObject objj = (WorldObject)node.Tag;
            NameService nameC = (NameService)objj.GetService(typeof(NameService));
            worldObj.RemoveWorldObject(nameC.ObjectName());
            parentNode.Tag = worldObj;
        }

        /* When the Export World button is pressed start a routine to serialize the world */
        private void ExportWorld_Click(object sender, EventArgs e)
        {
            ObjectList.TopNode.Tag = game.root;
            /* If the world have a name */
            if (this.textBox1.Text != "")
            {
                /* Start a dialog to choose where to save the exported file */
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Save World";
                saveFile.DefaultExt = ".xml";
                saveFile.Filter = "XML Files (*.xml)|*.xml|" +
                                    "All Files (*.*)|*.*";
                saveFile.AddExtension = true;
                saveFile.OverwritePrompt = true;
                saveFile.FileName = this.textBox1.Text;
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    /* Transfrom the services of the created World Objects to Factories */
                    this.game.root = (WorldObject)this.ObjectList.TopNode.Tag;
                    Cursor = Cursors.WaitCursor;
                    ServicesToFactories(this.game.root);
                    /* Start the serialization */
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Indent = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(saveFile.FileName, xmlSettings))
                    {
                        IntermediateSerializer.Serialize(xmlWriter, this.game.root, null);
                    }
                }
                Cursor = Cursors.Arrow;
                this.game.Exit();
                this.Close();
            }
            /* In case that the world name is not yet defined ask for one */
            else
            {
                //InsertName insertName = new InsertName();
                //insertName.ShowDialog();
            }
        }

        /* Method that moves files from a source path to a directory within the program */
        public string MoveFiles(string sourcePath)
        {
            string relativePath = Path.Combine(Assembly.GetExecutingAssembly().Location, "../../../../Content");
            string targetPath = Path.GetFullPath(relativePath) + "\\" + this.textBox1.Text;
            /* If the targer directory does not exists create a new one */
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            /* If the source directory exists move the file to the target directory */
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                /* Copy the files and overwrite destination files if they already exist */
                foreach (string s in files)
                {
                    /* Use path methods to extract only the file name from the path */
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            return targetPath;
        }

        /* Method that receives a World Object and converts all its services to factories */
        public void ServicesToFactories(WorldObject obj)
        {
            foreach (WorldObject wObj in obj.WObjects)
            {
                if (wObj.ContainService(typeof(CameraService)))
                {
                    ModelServiceToModelFactory(this.camera, wObj);
                    NameServiceToNameFactory(this.camera, wObj);
                    PositionServiceToPositionFactory(this.camera, wObj);
                    CameraServiceToCameraFactory(this.camera, wObj);
                    this.camera.objectBuilder.Add(new DrawFactory());
                    UpdateCameraServiceToUptadeCamerFactory(this.camera, wObj);
                    wObj.RemoveAllServices();
                    ServicesToFactories(this.camera);
                }
                else
                {
                    ModelServiceToModelFactory(wObj, wObj);
                    NameServiceToNameFactory(wObj, wObj);
                    PositionServiceToPositionFactory(wObj, wObj);
                    CameraServiceToCameraFactory(wObj, wObj);
                    ToDrawServiceToToDrawFactory(wObj, wObj);
                    UpdateCameraServiceToUptadeCamerFactory(wObj, wObj);
                    wObj.RemoveAllServices();
                    ServicesToFactories(wObj);
                }
            }
        }

        /* Method that converts a Name Service to a Name Service */
        public void NameServiceToNameFactory(WorldObject wObji, WorldObject wObjf)
        {
            if (wObji.ContainService(typeof(NameService)))
            {
                NameService name = (NameService)wObji.GetService(typeof(NameService));
                NameFactory nameFact = new NameFactory();
                nameFact.objectName = name.name;
                /* Save the factory in the object builder list */
                wObjf.objectBuilder.Add(nameFact);
            }
        }

        /* Method that converts a Position Service to a Position Service */
        public void PositionServiceToPositionFactory(WorldObject wObji, WorldObject wObjf)
        {
            if (wObji.ContainService(typeof(PositionService)))
            {
                PositionService pos = (PositionService)wObji.GetService(typeof(PositionService));
                PositionFactory posFact = new PositionFactory();
                posFact.position = pos.position;
                posFact.rotation = pos.rotation;
                posFact.reference = pos.reference;
                /* Save the factory in the object builder list */
                wObjf.objectBuilder.Add(posFact);
            }
        }

        /* Method that adds a Model Factory */
        public void ModelServiceToModelFactory(WorldObject wObji, WorldObject wObjf)
        {
            if (wObji.ContainService(typeof(Model)))
            {
                NameService name = (NameService)wObji.GetService(typeof(NameService));
                ModelFactory modFact = new ModelFactory();
                /* Take the built model from the temporary directory and store it in the program */
                modFact.directory = MoveFiles(this.contentBuilder.OutputDirectory);
                modFact.name = name.name;
                /* Save the factory in the object builder list */
                wObjf.objectBuilder.Add(modFact);
            }
        }

        /* Method that converts a Draw Service into a Draw Factory */
        public void ToDrawServiceToToDrawFactory(WorldObject wObji, WorldObject wObjf)
        {
            if (wObji.ContainService(typeof(DrawService)))
            {
                DrawFactory toDrawFact = new DrawFactory();
                /* Save the factory in the object builder list */
                wObjf.objectBuilder.Add(toDrawFact);
            }
        }

        /* Method that converts a Camera Service to a Camera Factory */
        public void CameraServiceToCameraFactory(WorldObject wObji, WorldObject wObjf)
        {
            if (wObji.ContainService(typeof(CameraService)))
            {
                CameraService cam = (CameraService)wObji.GetService(typeof(CameraService));
                CameraFactory camFact = new CameraFactory();
                camFact.aspectRatio = cam.aspectRatio;
                camFact.bottom = cam.bottom;
                camFact.farPlane = cam.farPlane;
                camFact.fieldOfView = cam.fieldOfView;
                camFact.IsPerspective = cam.IsPerspective;
                camFact.left = cam.left;
                camFact.nearPlane = cam.nearPlane;
                camFact.right = cam.right;
                camFact.top = cam.top;
                /* Save the factory in the object builder list */
                wObjf.objectBuilder.Add(camFact);
            }
        }

        /* Method that converts the Service that updates the Camera to the respective Factory */
        public void UpdateCameraServiceToUptadeCamerFactory(WorldObject wObji, WorldObject wObjf)
        {
            //if (wObji.GetService(typeof(UpdateCameraFile)) != null)
            //{
            //    UpdateCameraFile upCamFile = (UpdateCameraFile)wObji.GetService(typeof(UpdateCameraFile));
            //    UpdateCameraFileFactory upCamFileFac = new UpdateCameraFileFactory();
            //    upCamFileFac.filePath = upCamFile.file;
            //    wObjf.objectBuilder.Add(upCamFileFac);
            //}

            //else if (wObji.GetService(typeof(StaticCameraSaveRaw)) != null)
            //{
            //    StaticCameraSaveRaw stCam = (StaticCameraSaveRaw)wObji.GetService(typeof(StaticCameraSaveRaw));
            //    StaticCameraSaveRawFactory stCamFac = new StaticCameraSaveRawFactory();
            //    stCamFac.path = stCam.path;
            //    wObjf.objectBuilder.Add(stCamFac);
            //}

            //else if (wObji.GetService(typeof(UpdateCameraFTDI)) != null)
            //{
            //    UpdateCameraFTDI upCamFTDI = (UpdateCameraFTDI)wObji.GetService(typeof(UpdateCameraFTDI));
            //    UpdateCameraFTDIFactory upCamFTDIFac = new UpdateCameraFTDIFactory();
            //    upCamFTDIFac.path = upCamFTDI.path;
            //    upCamFTDIFac.fCalib = upCamFTDI.fCalib;
            //    upCamFTDIFac.gFCLoop = upCamFTDI.gFCLoop;
            //    upCamFTDIFac.gRCLoop = upCamFTDI.gRCLoop;
            //    upCamFTDIFac.rCalib = upCamFTDI.rCalib;
            //    wObjf.objectBuilder.Add(upCamFTDIFac);
            //}

            //else if (wObji.GetService(typeof(UpdateCameraFTDIRot)) != null)
            //{
            //    UpdateCameraFTDIRot upCamFTDIR = (UpdateCameraFTDIRot)wObji.GetService(typeof(UpdateCameraFTDIRot));
            //    UpdateCameraFTDIRotFactory upCamFTDIRFac = new UpdateCameraFTDIRotFactory();
            //    upCamFTDIRFac.path = upCamFTDIR.path;
            //    upCamFTDIRFac.fCalib = upCamFTDIR.fCalib;
            //    upCamFTDIRFac.gFCLoop = upCamFTDIR.gFCLoop;
            //    upCamFTDIRFac.gRCLoop = upCamFTDIR.gRCLoop;
            //    upCamFTDIRFac.rCalib = upCamFTDIR.rCalib;
            //    wObjf.objectBuilder.Add(upCamFTDIRFac);
            //}

            //else if (wObji.GetService(typeof(UpdateCameraFTDIFront)) != null)
            //{
            //    UpdateCameraFTDIFront upCamFTDIF = (UpdateCameraFTDIFront)wObji.GetService(typeof(UpdateCameraFTDIFront));
            //    UpdateCameraFTDIFrontFactory upCamFTDIFFac = new UpdateCameraFTDIFrontFactory();
            //    upCamFTDIFFac.path = upCamFTDIF.path;
            //    upCamFTDIFFac.fCalib = upCamFTDIF.fCalib;
            //    upCamFTDIFFac.gFCLoop = upCamFTDIF.gFCLoop;
            //    upCamFTDIFFac.gRCLoop = upCamFTDIF.gRCLoop;
            //    upCamFTDIFFac.rCalib = upCamFTDIF.rCalib;
            //    wObjf.objectBuilder.Add(upCamFTDIFFac);
            //}

            //else if (wObji.GetService(typeof(UpdateCameraKeyboard)) != null)
            //{
            //    UpdateCameraKeyboard upCamKey = (UpdateCameraKeyboard)wObji.GetService(typeof(UpdateCameraKeyboard));
            //    UpdateCameraKeyFactory upCamKeyF = new UpdateCameraKeyFactory();
            //    wObjf.objectBuilder.Add(upCamKeyF);
            //}
        }

        public WorldObject BuildCamera()
        {
            WorldObject cam = new WorldObject();
            cam.AddService(typeof(NameService), new NameService("Fly", this.game));
            PositionService pos = new PositionService(this.game);
            pos.position = new Vector3(0, 0, 0);
            pos.reference = new Vector3(0, 0, 100);
            cam.AddService(typeof(PositionService), pos);
            //CameraService camServ = new CameraService(cam, this.game, 0.785398f, 1.33333f, 0.5f, 100f);
            CameraService camServ = new CameraService(cam, this.game, -5, 5, -5, 5, 0.5f, 100f);
            cam.AddService(typeof(CameraService), camServ);
            cam.AddService(typeof(DrawService), new DrawService(cam, this.game));
            //cam.AddService(typeof(UpdateCameraKeyboard), new UpdateCameraKeyboard(cam, this.game));
            return cam;
        }

        private void SelectCamera_Click(object sender, EventArgs e)
        {
            CameraEditor selectCam = new CameraEditor(this);
            selectCam.ShowDialog();
            this.camera = selectCam.GetCamera();
            this.game.root.AddWorldObject(BuildCamera());
        }

        private void ObjectList_NodeMouseDoubleClick(object sender, EventArgs e)
        {
            WorldObject wObj = (WorldObject)this.ObjectList.SelectedNode.Tag;
            if (wObj.ContainService(typeof(Form)))
            {
                Form form = (Form)wObj.GetService(typeof(Form));
                form.ShowDialog();
            }
        }

        /* When the Exit button is pressed Exit game and close the application */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.game.Exit();
            this.Close();
        }

    }
}
