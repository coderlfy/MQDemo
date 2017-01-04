namespace MQDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewPerson = new System.Windows.Forms.Button();
            this.resultViewCtrl1 = new MQControl.ResultViewCtrl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "下面是个原生控件用于显示学生成绩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btnViewPerson
            // 
            this.btnViewPerson.Location = new System.Drawing.Point(309, 152);
            this.btnViewPerson.Name = "btnViewPerson";
            this.btnViewPerson.Size = new System.Drawing.Size(116, 23);
            this.btnViewPerson.TabIndex = 3;
            this.btnViewPerson.Text = "显示学生详细信息";
            this.btnViewPerson.UseVisualStyleBackColor = true;
            this.btnViewPerson.Click += new System.EventHandler(this.btnViewPerson_Click);
            // 
            // resultViewCtrl1
            // 
            this.resultViewCtrl1.Location = new System.Drawing.Point(19, 23);
            this.resultViewCtrl1.Name = "resultViewCtrl1";
            this.resultViewCtrl1.Size = new System.Drawing.Size(253, 123);
            this.resultViewCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 301);
            this.Controls.Add(this.btnViewPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultViewCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MQControl.ResultViewCtrl resultViewCtrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewPerson;
    }
}

