using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_graphic
{
    public partial class Form1 : Form
    {
        private GLControl panel;
        private Shader shader;
        private Thread updateThread;

        public Form1()
        {
            InitializeComponent();

            this.panel = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(ColorFormat.Empty, 24, 0, 8));
            panel.Paint += GLPaint;

            this.SuspendLayout();

            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(this.Width  * 2 / 3, this.Height);
            this.panel.TabIndex = 0;

            this.Controls.Add(this.panel);
            this.ResumeLayout(false);

            tetrXBar.Minimum     = -3;
            tetrXBar.Maximum     =  3;
            tetrYBar.Minimum     = -3;
            tetrYBar.Maximum     =  3;
            tetrZBar.Minimum     = -3;
            tetrZBar.Maximum     =  3;
            tetrColorBar.Maximum =  4;
            refractionBar.Minimum = 2;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            panel.MakeCurrent();

            shader = new Shader(panel.Width, panel.Height);

            updateThread = new Thread(Update);
            updateThread.Start();

            this.Closed += CloseEvent;
        }


        private void GLPaint(object sender, PaintEventArgs e)
        {
            panel.MakeCurrent();
            shader.DrawQuads();
            panel.SwapBuffers();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            this.panel.Width  = this.Width  * 2 / 3;
            this.panel.Height = this.Height;

            if (this.Created)
                shader.Resize(panel.Width, panel.Height);
        }


        private new void Update()
        {
            bool directionX = true;
            bool directionZ = true;
            float step = 0.000004f;

            while(true)
            {
                switch(directionX)
                {
                    case true:
                        while (shader.lightPostion.X < 4)
                        {
                            shader.lightPostion.X += step;
                            panel.Invalidate();
                        }    
                        break;

                    case false:
                        while (shader.lightPostion.X > -4)
                        {
                            shader.lightPostion.X -= step;
                            panel.Invalidate();
                        }
                        break;

                    default:

                        break;
                }

                switch (directionZ)
                {
                    case true:
                        while (shader.lightPostion.Z < 3)
                        {
                            shader.lightPostion.Z += step;
                            panel.Invalidate();
                        }
                        break;

                    case false:
                        while (shader.lightPostion.Z > -3)
                        {
                            shader.lightPostion.Z -= step;
                            panel.Invalidate();
                        }
                        break;

                    default:

                        break;
                }

                directionX = !directionX;
                directionZ = !directionZ;
            }
        }


        public void CloseEvent(object sender, System.EventArgs e)
        {
            updateThread.Abort();
        }


        private void tetrSizeBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.SetTetrSize(trackBar.Value);
        }

        private void tetrXBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar    = sender as TrackBar;
            shader.tetrPosition.X = trackBar.Value;
        }

        private void tetrYBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar    = sender as TrackBar;
            shader.tetrPosition.Y = trackBar.Value;
        }

        private void tetrZBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar    = sender as TrackBar;
            shader.tetrPosition.Z = trackBar.Value;
        }

        private void tetrColorBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            shader.tetrColor   = new Vector3(trackBar.Value);
        }

        private void refractionBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar      = sender as TrackBar;
            shader.lightRefraction = new Vector3((float)trackBar.Value / (float)trackBar.Maximum);
        }
    }
}
