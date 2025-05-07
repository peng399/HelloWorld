namespace Hello_World
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSay = new System.Windows.Forms.Button();
            this.labHelloWorld = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSay
            // 
            this.btnSay.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnSay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSay.Location = new System.Drawing.Point(32, 51);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(270, 117);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say Hello World";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // labHelloWorld
            // 
            this.labHelloWorld.AutoSize = true;
            this.labHelloWorld.Font = new System.Drawing.Font("新細明體", 20F);
            this.labHelloWorld.Location = new System.Drawing.Point(12, 291);
            this.labHelloWorld.Name = "labHelloWorld";
            this.labHelloWorld.Size = new System.Drawing.Size(93, 34);
            this.labHelloWorld.TabIndex = 1;
            this.labHelloWorld.Text = "label1";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.SystemColors.Control;
            this.btnCount.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCount.Location = new System.Drawing.Point(376, 52);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(271, 116);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("新細明體", 20F);
            this.labCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labCount.Location = new System.Drawing.Point(370, 291);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(93, 34);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.SystemColors.Control;
            this.labTime.Font = new System.Drawing.Font("新細明體", 20F);
            this.labTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labTime.Location = new System.Drawing.Point(12, 388);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(93, 34);
            this.labTime.TabIndex = 4;
            this.labTime.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.labHelloWorld);
            this.Controls.Add(this.btnSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Label labHelloWorld;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labTime;
    }
}

