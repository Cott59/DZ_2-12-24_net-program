namespace DZ_2_12_24_net_program
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_ipadress = new System.Windows.Forms.TextBox();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_outputdata = new System.Windows.Forms.TextBox();
            this.btn_outlog = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbox_ipadress
            // 
            this.tbox_ipadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_ipadress.Location = new System.Drawing.Point(47, 26);
            this.tbox_ipadress.Name = "tbox_ipadress";
            this.tbox_ipadress.Size = new System.Drawing.Size(197, 26);
            this.tbox_ipadress.TabIndex = 2;
            this.tbox_ipadress.Text = "127.0.0.1";
            // 
            // tbox_port
            // 
            this.tbox_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_port.Location = new System.Drawing.Point(308, 27);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(100, 26);
            this.tbox_port.TabIndex = 3;
            this.tbox_port.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbox_outputdata
            // 
            this.tbox_outputdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_outputdata.Location = new System.Drawing.Point(21, 85);
            this.tbox_outputdata.Multiline = true;
            this.tbox_outputdata.Name = "tbox_outputdata";
            this.tbox_outputdata.Size = new System.Drawing.Size(387, 269);
            this.tbox_outputdata.TabIndex = 6;
            // 
            // btn_outlog
            // 
            this.btn_outlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_outlog.Image = global::DZ_2_12_24_net_program.Properties.Resources.free_icon_font_search_alt_39148721;
            this.btn_outlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_outlog.Location = new System.Drawing.Point(21, 381);
            this.btn_outlog.Name = "btn_outlog";
            this.btn_outlog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_outlog.Size = new System.Drawing.Size(144, 44);
            this.btn_outlog.TabIndex = 7;
            this.btn_outlog.Text = "Журнал";
            this.btn_outlog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_outlog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_outlog.UseVisualStyleBackColor = true;
            this.btn_outlog.Click += new System.EventHandler(this.btn_outlog_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Image = global::DZ_2_12_24_net_program.Properties.Resources.free_icon_font_data_transfer_39147741;
            this.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connect.Location = new System.Drawing.Point(204, 381);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_connect.Size = new System.Drawing.Size(204, 44);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Подключиться";
            this.btn_connect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_connect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_outlog);
            this.Controls.Add(this.tbox_outputdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tbox_port);
            this.Controls.Add(this.tbox_ipadress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_ipadress;
        private System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_outputdata;
        private System.Windows.Forms.Button btn_outlog;
    }
}

