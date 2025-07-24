namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting rdpControl;
        private System.Windows.Forms.Button button1;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            rdpControl = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)rdpControl).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 0;
            button1.Text = "Conectar RDP";
            button1.Click += button1_Click;
            // 
            // rdpControl
            // 
            rdpControl.Dock = DockStyle.Fill;
            rdpControl.Enabled = true;
            rdpControl.Location = new Point(0, 0);
            rdpControl.Name = "rdpControl";
            rdpControl.OcxState = (AxHost.State)resources.GetObject("rdpControl.OcxState");
            rdpControl.Size = new Size(976, 607);
            rdpControl.TabIndex = 0;
            rdpControl.OnConnecting += rdpControl_OnConnecting;
            // 
            // Form1
            // 
            ClientSize = new Size(976, 607);
            Controls.Add(button1);
            Controls.Add(rdpControl);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)rdpControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        
    }
}
