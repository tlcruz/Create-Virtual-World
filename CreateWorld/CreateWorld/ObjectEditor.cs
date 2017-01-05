using CreateWorld.Dialogs;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VRLibrary.Stimulus;
using VRLibrary.Stimulus.Services;
using VRLibrary.Stimulus.Subsystems;

namespace CreateWorld
{
    public partial class ObjectEditor : Form
    {
        /* Create World that called this Object Editor */
        CreateWorld createWorld;
        /* Number format to pass from string to float */
        NumberFormatInfo provider = new NumberFormatInfo();
        ContentManager contentManager;
        public WorldObject wObj;

        public void Defaults()
        {
            this.StringX.Text = "0";
            this.StringY.Text = "0";
            this.StringZ.Text = "0";
            this.StringRX.Text = "0";
            this.StringRY.Text = "0";
            this.StringRZ.Text = "0";
        }

        public ObjectEditor(CreateWorld createWorld)
        {
            /* Initialize the World Object to be created */
            wObj = new WorldObject();
            provider.NumberDecimalSeparator = ".";
            this.createWorld = createWorld;
            contentManager = new ContentManager(this.createWorld.game.Services, this.createWorld.contentBuilder.OutputDirectory);
            InitializeComponent();
            this.createWorld.ObjectList.TopNode.Tag = this.createWorld.game.root;
            /* Store this from as a Service of the World Object */
            if (!this.wObj.ContainService(typeof(Form)))
            {
                this.wObj.AddService(typeof(Form), this);
            }
            Defaults();
        }

        /* Store the name defined by the user */
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.wObj.ContainService(typeof(NameService)))
            {
                NameService nameService = new NameService(this.NameBox.Text, this.createWorld.game);
                this.wObj.AddService(typeof(NameService), nameService);
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
            }

            else
            {
                NameService nameService = (NameService)this.wObj.GetService(typeof(NameService));
                nameService.name = this.NameBox.Text;
            }
        }

        /* Store the X position defined by the user */
        private void StringX_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringX.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.position.X = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.position.X = (float)i;
                }
            }
            else
            {
                if (this.StringX.Text != "" && this.StringX.Text != "-")
                {
                    this.StringX.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        /* Store the Y position defined by the user */
        private void StringY_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringY.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.position.Y = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.position.Y = (float)i;
                }
            }
            else
            {
                if (this.StringY.Text != "" && this.StringY.Text != "-")
                {
                    this.StringY.Text = "0";
                    InsertNumber insnumb = new InsertNumber();
                    insnumb.ShowDialog();
                }
            }
        }

        /* Store the Z position defined by the user */
        private void StringZ_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringZ.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.position.Z = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.position.Z = (float)i;
                }
            }
            else
            {
                if (this.StringZ.Text != "" && this.StringZ.Text != "-")
                {
                    this.StringZ.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        /* Store the X rotation defined by the user */
        private void StringRX_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringRX.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.rotation.X = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.rotation.X = (float)i;
                }
            }
            else
            {
                if (this.StringRX.Text != "" && this.StringRX.Text != "-")
                {
                    this.StringRX.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        /* Store the Y rotation defined by the user */
        private void StringRY_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringRY.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.rotation.Y = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.rotation.Y = (float)i;
                }
            }
            else
            {
                if (this.StringRY.Text != "" && this.StringRY.Text != "-")
                {
                    this.StringRY.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        /* Store the Z rotation defined by the user */
        private void StringRZ_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (Double.TryParse(this.StringRZ.Text, NumberStyles.Float, provider, out i))
            {
                if (!this.wObj.ContainService(typeof(PositionService)))
                {
                    PositionService positionService = new PositionService(this.createWorld.game);
                    positionService.rotation.Z = (float)i;
                    this.wObj.AddService(typeof(PositionService), positionService);
                }
                else
                {
                    PositionService positionService = (PositionService)this.wObj.GetService(typeof(PositionService));
                    positionService.rotation.Z = (float)i;
                }
            }
            else
            {
                if (this.StringRZ.Text != "" && this.StringRZ.Text != "-")
                {
                    this.StringRZ.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        /* When the Add model button is pressed */
        private void AddModelButton_Click(object sender, EventArgs e)
        {
            /* If the name and possition of the object are not yet defined ask for them */
            if (!this.wObj.ContainService(typeof(PositionService)))
            {
                InsertPosition insertPosition = new InsertPosition();
                insertPosition.ShowDialog();
            }
            else if (!this.wObj.ContainService(typeof(NameService)))
            {
                InsertName insertName = new InsertName();
                insertName.ShowDialog();
            }
            else
            {
                /* Open a dialog to select the .FBX model */
                OpenFileDialog fileDialog = new OpenFileDialog();
                string assemblyLocation = Assembly.GetExecutingAssembly().Location;
                string contentPath = Path.GetFullPath(assemblyLocation);

                fileDialog.InitialDirectory = contentPath;

                fileDialog.Title = "Load Model";

                fileDialog.Filter = "Model Files (*.fbx;*.x)|*.fbx;*.x|" +
                                    "FBX Files (*.fbx)|*.fbx|" +
                                    "X Files (*.x)|*.x|" +
                                    "All Files (*.*)|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadModel(fileDialog.FileName);
                }
                this.StringModel.Text = fileDialog.FileName;
            }
        }

        /* Build a .FBX model to a .XNB file */
        public void LoadModel(string fileName)
        {
            NameService name = (NameService)wObj.GetService(typeof(NameService));
            Cursor = Cursors.WaitCursor;
            /* Prepare the content builder project */
            this.createWorld.contentBuilder.Add(fileName, name.name, null, "ModelProcessor");
            /* Build the model */
            string buildError = this.createWorld.contentBuilder.Build();

            if (buildError == null)
            {
                if (!wObj.ContainService(typeof(DrawService)))
                {
                    /* Try load the Model and adress it as a Service to the World Object */
                    Model model = (Model)contentManager.Load<Model>(name.name);
                    wObj.AddService(typeof(Model), model);
                    DrawService toDrawService = new DrawService(wObj, this.createWorld.game);
                    wObj.AddService(typeof(DrawService), toDrawService);
                }
                else
                {
                    DrawService toDrawService = (DrawService)wObj.GetService(typeof(DrawService));
                    /* Try load the Model and adress it as a Service to the World Object */
                    Model model = (Model)contentManager.Load<Model>(name.name);
                    toDrawService.model = model;
                    wObj.RemoveService(typeof(Model));
                    wObj.AddService(typeof(Model), model);
                }
            }
            else
            {
                ProblemLoadingModel probL = new ProblemLoadingModel();
                probL.ShowDialog();
                this.StringModel.Text = "";
            }
            Cursor = Cursors.Arrow;
        }

        /* When the Remove model button is pressed */
        private void RemoveModelButton_Click(object sender, EventArgs e)
        {
            if (this.wObj.GetService(typeof(Model)) != null)
            {
                RenderSubsystem render = (RenderSubsystem)this.createWorld.game.Services.GetService(typeof(RenderSubsystem));
                if (this.wObj.ContainService(typeof(NameService)))
                {
                    NameService name = (NameService)this.wObj.GetService(typeof(NameService));
                    render.DrawServices.Remove(name.ObjectName());
                    this.wObj.RemoveService(typeof(Model));
                    this.wObj.RemoveService(typeof(DrawService));
                    this.StringModel.Text = "";
                    if (System.IO.Directory.Exists(this.createWorld.contentBuilder.OutputDirectory + "\\" + name.ObjectName() + ".xnb"))
                    {
                        System.IO.Directory.Delete(this.createWorld.contentBuilder.OutputDirectory + "\\" + name.ObjectName() + ".xnb");
                    }
                }
            }
            else
            {
                if (this.wObj.ContainService(typeof(NameService)))
                {
                    NameService name = (NameService)this.wObj.GetService(typeof(NameService));
                    this.StringModel.Text = "";
                    if (System.IO.Directory.Exists(this.createWorld.contentBuilder.OutputDirectory + "\\" + name.ObjectName() + ".xnb"))
                    {
                        System.IO.Directory.Delete(this.createWorld.contentBuilder.OutputDirectory + "\\" + name.ObjectName() + ".xnb");
                    }
                }
            }
        }

        ///* When an Update is selected */
        private void UpdateTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* If the name and position of the World Object are not yet defined ask for them */
            if (!this.wObj.ContainService(typeof(PositionService)))
            {
                InsertPosition insertPosition = new InsertPosition();
                insertPosition.ShowDialog();
            }
            else if (!this.wObj.ContainService(typeof(NameService)))
            {
                InsertName insertName = new InsertName();
                insertName.ShowDialog();
            }
            /* If there is still no Collision Service add the chosen one */
            else if (!this.wObj.ContainService(typeof(UpdateService)))
            {
                if (SelectedUpdate())
                    this.UpdateTypes.Enabled = false;
            }
        }

        /* Store the selected Collision Object as a Service in the World Object */
        public bool SelectedUpdate()
        {
            switch (this.UpdateTypes.SelectedItem.ToString())
            {
                ///* If the user asks for a box to bound the Model */
                //case "CollisionBox":
                //    if (!this.wObj.ContainService(typeof(Model)))
                //    {
                //        /* If there is no Model ask for one */
                //        InsertModel insertModel = new InsertModel();
                //        insertModel.ShowDialog();
                //        this.UpdateTypeList.Enabled = true;
                //        return false;
                //    }
                //    else
                //    {
                //        CollisionBox colBox = new CollisionBox(wObj, this.createWorld.game);
                //        this.wObj.AddService(typeof(CollisionBox), colBox);
                //        this.UpdateTypeList.Enabled = false;
                //        return true;
                //    }

                ///* If the user asks for a sphere */
                //case "CollisionSphere":
                //    /* Open a dialog to get the sphere parameters */
                //    EditColCamera colCamera = new EditColCamera();
                //    colCamera.ShowDialog();
                //    this.wObj.AddService(typeof(CollisionSphere), colCamera.NewCollisionCamera(wObj, this.createWorld.game));
                //    this.UpdateTypeList.Enabled = false;
                //    return true;

                default:
                    return false;
            }
        }

        /* When the button Done is pressed */
        private void DoneButton_Click(object sender, EventArgs e)
        {
            /* If the name of the World Object is not yet defined ask for one */
            if (!wObj.ContainService(typeof(NameService)))
            {
                InsertName insertName = new InsertName();
                insertName.ShowDialog();
            }
            else
            {
                /* In case it is not already there, add this World Object to the tree of World Objects in the Create World */
                if (!this.wObj.ContainService(typeof(TreeNode)))
                {
                    TreeNode node = new TreeNode(this.NameBox.Text);
                    node.Tag = wObj;
                    AttributeWObj(node, this.createWorld.ObjectList.SelectedNode);
                    this.createWorld.ObjectList.SelectedNode.Nodes.Add(node);
                    this.wObj.AddService(typeof(TreeNode), node);
                }
                /* In case it has already been added refresh the just the node name */
                else
                {
                    this.createWorld.ObjectList.SelectedNode.Text = this.NameBox.Text;
                }
                this.Hide();
            }
        }

        /* Put the World Object in the World Object tree in the CreateWorld that called this Object Editor */
        public void AttributeWObj(TreeNode node, TreeNode parentNode)
        {
            WorldObject wOb = (WorldObject)parentNode.Tag;
            wOb.AddWorldObject((WorldObject)node.Tag);
            parentNode.Tag = wOb;
        }


    }
}
