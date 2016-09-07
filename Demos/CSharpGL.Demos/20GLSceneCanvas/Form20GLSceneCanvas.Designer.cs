﻿namespace CSharpGL.Demos
{
    partial class Form20GLSceneCanvas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CSharpGL.FirstPerspectiveManipulater firstPerspectiveManipulater1 = new CSharpGL.FirstPerspectiveManipulater();
            this.glSceneCanvas1 = new CSharpGL.GLSceneCanvas();
            ((System.ComponentModel.ISupportInitialize)(this.glSceneCanvas1)).BeginInit();
            this.SuspendLayout();
            // 
            // glSceneCanvas1
            // 
            firstPerspectiveManipulater1.BackKey = 's';
            firstPerspectiveManipulater1.BindingMouseButtons = System.Windows.Forms.MouseButtons.Right;
            firstPerspectiveManipulater1.DownKey = 'e';
            firstPerspectiveManipulater1.FrontKey = 'w';
            firstPerspectiveManipulater1.HorizontalRotationSpeed = 0.002F;
            firstPerspectiveManipulater1.LeftKey = 'a';
            firstPerspectiveManipulater1.RightKey = 'd';
            firstPerspectiveManipulater1.StepLength = 0.1F;
            firstPerspectiveManipulater1.UpKey = 'q';
            firstPerspectiveManipulater1.VerticalRotationSpeed = 0.002F;
            this.glSceneCanvas1.CameraManipulater = firstPerspectiveManipulater1;
            this.glSceneCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glSceneCanvas1.Location = new System.Drawing.Point(0, 0);
            this.glSceneCanvas1.Name = "glSceneCanvas1";
            this.glSceneCanvas1.OpenGLVersion = CSharpGL.GLVersion.OpenGL2_1;
            this.glSceneCanvas1.RenderTrigger = CSharpGL.RenderTrigger.TimerBased;
            this.glSceneCanvas1.ShowSystemCursor = true;
            this.glSceneCanvas1.Size = new System.Drawing.Size(578, 417);
            this.glSceneCanvas1.TabIndex = 0;
            this.glSceneCanvas1.Load += new System.EventHandler(this.glSceneCanvas1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 417);
            this.Controls.Add(this.glSceneCanvas1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.glSceneCanvas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GLSceneCanvas glSceneCanvas1;
    }
}