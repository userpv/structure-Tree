namespace Tree_111
{
	partial class Form1
	{
		
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox textBox1;
		private System.Windows.Forms.ToolStripButton Button1;
		private System.Windows.Forms.ToolStripTextBox textBox2;
		private System.Windows.Forms.ToolStripButton Button2;
		private System.Windows.Forms.ToolStripButton Button3;
		private System.Windows.Forms.ToolStripButton Button4;
		private System.Windows.Forms.ToolStripTextBox textBox3;
		private System.Windows.Forms.ToolStripButton Button5;
		private System.Windows.Forms.ToolStripTextBox textBox4;
		private System.Windows.Forms.ToolStripButton Button6;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.Button1 = new System.Windows.Forms.ToolStripButton();
			this.textBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.Button2 = new System.Windows.Forms.ToolStripButton();
			this.Button3 = new System.Windows.Forms.ToolStripButton();
			this.Button4 = new System.Windows.Forms.ToolStripButton();
			this.textBox3 = new System.Windows.Forms.ToolStripTextBox();
			this.Button5 = new System.Windows.Forms.ToolStripButton();
			this.textBox4 = new System.Windows.Forms.ToolStripTextBox();
			this.Button6 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.textBox1,
			this.Button1,
			this.textBox2,
			this.Button2,
			this.Button3,
			this.Button4,
			this.textBox3,
			this.Button5,
			this.textBox4,
			this.Button6});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(999, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 25);
			// 
			// Button1
			// 
			this.Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
			this.Button1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(33, 22);
			this.Button1.Text = "Add";
			this.Button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 25);
			// 
			// Button2
			// 
			this.Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
			this.Button2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(34, 22);
			this.Button2.Text = "Find";
			this.Button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Button3
			// 
			this.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
			this.Button3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(56, 22);
			this.Button3.Text = "Random";
			this.Button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Button4
			// 
			this.Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
			this.Button4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(38, 22);
			this.Button4.Text = "Clear";
			this.Button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox3
			// 
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 25);
			// 
			// Button5
			// 
			this.Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
			this.Button5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(39, 22);
			this.Button5.Text = "Lebel";
			this.Button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox4
			// 
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 25);
			// 
			// Button6
			// 
			this.Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
			this.Button6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(61, 22);
			this.Button6.Text = "Remouve";
			this.Button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(999, 636);
			this.Controls.Add(this.toolStrip1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1Paint);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
	}
}
