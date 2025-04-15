namespace HelloWorldform
{
    partial class lblTitel
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitel2 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel2
            // 
            this.lblTitel2.Font = new System.Drawing.Font("바탕체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitel2.Location = new System.Drawing.Point(12, 18);
            this.lblTitel2.Name = "lblTitel2";
            this.lblTitel2.Size = new System.Drawing.Size(372, 56);
            this.lblTitel2.TabIndex = 0;
            this.lblTitel2.Text = "헬로 월드?";
            this.lblTitel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPush.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPush.ForeColor = System.Drawing.Color.White;
            this.btnPush.Location = new System.Drawing.Point(30, 89);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(323, 75);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "눌러주세요.";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // lblTitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 176);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lblTitel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "lblTitel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "3212 이민서";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitel2;
        private System.Windows.Forms.Button btnPush;
    }
}

