using CreateWorld.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VRLibrary.Stimulus;
using VRLibrary.Stimulus.Services;

namespace CreateWorld
{
    public partial class CameraEditor : Form
    {
        CreateWorld form;
        public NumberFormatInfo provider = new NumberFormatInfo();
        WorldObject Camera;

        double fov;
        double asp;
        double np;
        double fp;
        double left;
        double right;
        double top;
        double bottom;
        double x;
        double y;
        double z;
        double rx;
        double ry;
        double rz;

        public void Defaults()
        {
            this.StringFOV.Text = "0.785398";
            this.StringAR.Text = "1.33333";
            this.StringFPP.Text = "100";
            this.StringNPP.Text = "0.5";
            this.StringLeft.Text = "-5";
            this.StringRight.Text = "5";
            this.StringTop.Text = "5";
            this.StringBottom.Text = "-5";
            this.StringNPO.Text = "0.5";
            this.StringFPO.Text = "100";
            this.StringX.Text = "0";
            this.StringY.Text = "0";
            this.StringZ.Text = "0";
            this.StringRX.Text = "0";
            this.StringRY.Text = "0";
            this.StringRZ.Text = "100";
            groupPerspective.Enabled = false;
            groupOrthographic.Enabled = true;
        }

        public CameraEditor(CreateWorld form)
        {
            this.form = form;
            provider.NumberDecimalSeparator = ".";
            Camera = new WorldObject();
            InitializeComponent();
            this.form.ObjectList.TopNode.Tag = this.form.game.root;
            if (!this.Camera.ContainService(typeof(Form)))
            {
                this.Camera.AddService(typeof(Form), this);
            }
            Defaults();
        }

        private void CameraType_CheckedChanged(object sender, EventArgs e)
        {
            if (CameraType.Checked)
            {
                groupPerspective.Enabled = true;
                groupOrthographic.Enabled = false;
            }
            else
            {
                groupPerspective.Enabled = false;
                groupOrthographic.Enabled = true;
            }
        }

        private void StringFOV_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringFOV.Text, NumberStyles.Float, provider, out fov)){}
            else
            {
                if (this.StringFOV.Text != "" && this.StringFOV.Text != "-")
                {
                    this.StringFOV.Text = "0.785398";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringAR_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringAR.Text, NumberStyles.Float, provider, out asp)){}
            else
            {
                if (this.StringAR.Text != "" && this.StringAR.Text != "-")
                {
                    this.StringAR.Text = "1.33333";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringNPP_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringNPP.Text, NumberStyles.Float, provider, out np)){}
            else
            {
                if (this.StringNPP.Text != "" && this.StringNPP.Text != "-")
                {
                    this.StringNPP.Text = "0.5";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringFPP_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringFPP.Text, NumberStyles.Float, provider, out fp)){}
            else
            {
                if (this.StringFPP.Text != "" && this.StringFPP.Text != "-")
                {
                    this.StringFPP.Text = "100";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringLeft_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringLeft.Text, NumberStyles.Float, provider, out left)){}
            else
            {
                if (this.StringLeft.Text != "" && this.StringLeft.Text != "-")
                {
                    this.StringLeft.Text = "-1";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringRight_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringRight.Text, NumberStyles.Float, provider, out right)){}
            else
            {
                if (this.StringRight.Text != "" && this.StringRight.Text != "-")
                {
                    this.StringRight.Text = "1";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringBottom_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringBottom.Text, NumberStyles.Float, provider, out bottom)){}
            else
            {
                if (this.StringBottom.Text != "" && this.StringBottom.Text != "-")
                {
                    this.StringBottom.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringTop_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringTop.Text, NumberStyles.Float, provider, out top)){}
            else
            {
                if (this.StringTop.Text != "" && this.StringTop.Text != "-")
                {
                    this.StringTop.Text = "2";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringNPO_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringNPO.Text, NumberStyles.Float, provider, out np)){}
            else
            {
                if (this.StringNPO.Text != "" && this.StringNPO.Text != "-")
                {
                    this.StringNPO.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringFPO_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringFPO.Text, NumberStyles.Float, provider, out fp)){}
            else
            {
                if (this.StringFPO.Text != "" && this.StringFPO.Text != "-")
                {
                    this.StringFPO.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringX_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringX.Text, NumberStyles.Float, provider, out x)){}
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

        private void StringY_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringY.Text, NumberStyles.Float, provider, out y)){}
            else
            {
                if (this.StringY.Text != "" && this.StringY.Text != "-")
                {
                    this.StringY.Text = "0";
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
            }
        }

        private void StringZ_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringZ.Text, NumberStyles.Float, provider, out z)){}
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

        private void StringRX_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringRX.Text, NumberStyles.Float, provider, out rx)){}
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

        private void StringRY_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringRY.Text, NumberStyles.Float, provider, out ry)){}
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

        private void StringRZ_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.StringRZ.Text, NumberStyles.Float, provider, out rz)){}
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

        private void StringSave_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            this.StringSave.Text = dialog.FileName;
        }

        public void AttributeWObj(TreeNode node, TreeNode parentNode)
        {
            WorldObject wOb = (WorldObject)parentNode.Tag;
            wOb.AddWorldObject((WorldObject)node.Tag);
            parentNode.Tag = wOb;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!this.Camera.ContainService(typeof(TreeNode)))
            {
                TreeNode node = new TreeNode("Camera");
                node.Tag = Camera;
                AttributeWObj(node, this.form.ObjectList.TopNode);
                this.Camera.AddService(typeof(TreeNode), node);
                this.form.ObjectList.TopNode.Nodes.Add(node);
            }

            else
            {
                this.form.ObjectList.SelectedNode.Text = "Camera";
            }
            this.Hide();
        }

        public CameraService GetCameraService(WorldObject cam)
        {
            if (CameraType.Checked)
            {
                if (!Double.TryParse(this.StringFOV.Text, NumberStyles.Float, provider, out fov))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringAR.Text, NumberStyles.Float, provider, out asp))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringNPP.Text, NumberStyles.Float, provider, out np))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringFPP.Text, NumberStyles.Float, provider, out fp))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                return new CameraService(cam, form.game, (float)fov, (float)asp, (float)fp, (float)np);
            }
            else
            {
                if (!Double.TryParse(this.StringLeft.Text, NumberStyles.Float, provider, out left))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringRight.Text, NumberStyles.Float, provider, out right))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringBottom.Text, NumberStyles.Float, provider, out bottom))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringTop.Text, NumberStyles.Float, provider, out top))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringNPO.Text, NumberStyles.Float, provider, out np))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                if (!Double.TryParse(this.StringFPO.Text, NumberStyles.Float, provider, out fp))
                {
                    InsertNumber insNumb = new InsertNumber();
                    insNumb.ShowDialog();
                }
                return new CameraService(cam, form.game, (float)left, (float)right, (float)bottom, (float)top, (float)fp, (float)np);
            }
        }

        public PositionService GetCameraInitialPosition(WorldObject cam)
        {
            PositionService pos = new PositionService(form.game);
            if (!Double.TryParse(this.StringX.Text, NumberStyles.Float, provider, out x))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            if (!Double.TryParse(this.StringY.Text, NumberStyles.Float, provider, out y))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            if (!Double.TryParse(this.StringZ.Text, NumberStyles.Float, provider, out z))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            if (!Double.TryParse(this.StringRX.Text, NumberStyles.Float, provider, out rx))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            if (!Double.TryParse(this.StringRY.Text, NumberStyles.Float, provider, out ry))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            if (!Double.TryParse(this.StringRZ.Text, NumberStyles.Float, provider, out rz))
            {
                InsertNumber insNumb = new InsertNumber();
                insNumb.ShowDialog();
            }
            else
            {
                pos.position.X = (float)x;
                pos.position.Y = (float)y;
                pos.position.Z = (float)z;
                pos.reference.X = (float)rx;
                pos.reference.Y = (float)ry;
                pos.reference.Z = (float)rz;
            }
            return pos;
        }

        public WorldObject GetCamera()
        {
            Camera.AddService(typeof(NameService), new NameService("Fly", this.form.game));
            Camera.AddService(typeof(PositionService), GetCameraInitialPosition(Camera));
            Camera.AddService(typeof(CameraService), GetCameraService(Camera));
            //Camera.AddService(typeof(DrawService), new DrawService(Camera, this.form.game));
            //switch (this.UpdateTypes.Text)
            //{
            //    //case "Keyboard":
            //    //    Camera.AddService(typeof(UpdateCameraKeyboard), new UpdateCameraKeyboard(Camera, form.game, true));
            //    //    return Camera;

            //    default:
            //        return null;
            //}
            return Camera;
        }

    }
}
