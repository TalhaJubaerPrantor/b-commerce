namespace Pts
{
    partial class Tracker
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
            this.t_confirm = new System.Windows.Forms.Label();
            this.t_payment = new System.Windows.Forms.Label();
            this.t_processing = new System.Windows.Forms.Label();
            this.t_packing = new System.Windows.Forms.Label();
            this.t_delivering = new System.Windows.Forms.Label();
            this.t_delivered = new System.Windows.Forms.Label();
            this.seeLocation = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.switchToUser = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.myOrders = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // t_confirm
            // 
            this.t_confirm.AutoSize = true;
            this.t_confirm.BackColor = System.Drawing.Color.Black;
            this.t_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_confirm.ForeColor = System.Drawing.Color.Transparent;
            this.t_confirm.Location = new System.Drawing.Point(666, 154);
            this.t_confirm.Name = "t_confirm";
            this.t_confirm.Size = new System.Drawing.Size(139, 31);
            this.t_confirm.TabIndex = 7;
            this.t_confirm.Text = "Confirmed";
            // 
            // t_payment
            // 
            this.t_payment.AutoSize = true;
            this.t_payment.BackColor = System.Drawing.Color.Black;
            this.t_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_payment.ForeColor = System.Drawing.Color.Transparent;
            this.t_payment.Location = new System.Drawing.Point(674, 208);
            this.t_payment.Name = "t_payment";
            this.t_payment.Size = new System.Drawing.Size(121, 31);
            this.t_payment.TabIndex = 8;
            this.t_payment.Text = "Payment";
            // 
            // t_processing
            // 
            this.t_processing.AutoSize = true;
            this.t_processing.BackColor = System.Drawing.Color.Black;
            this.t_processing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_processing.ForeColor = System.Drawing.SystemColors.Window;
            this.t_processing.Location = new System.Drawing.Point(653, 263);
            this.t_processing.Name = "t_processing";
            this.t_processing.Size = new System.Drawing.Size(163, 31);
            this.t_processing.TabIndex = 9;
            this.t_processing.Text = "Proccessing";
            // 
            // t_packing
            // 
            this.t_packing.AutoSize = true;
            this.t_packing.BackColor = System.Drawing.Color.Black;
            this.t_packing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_packing.ForeColor = System.Drawing.SystemColors.Window;
            this.t_packing.Location = new System.Drawing.Point(677, 315);
            this.t_packing.Name = "t_packing";
            this.t_packing.Size = new System.Drawing.Size(111, 31);
            this.t_packing.TabIndex = 10;
            this.t_packing.Text = "Packing";
            // 
            // t_delivering
            // 
            this.t_delivering.AutoSize = true;
            this.t_delivering.BackColor = System.Drawing.Color.Black;
            this.t_delivering.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_delivering.ForeColor = System.Drawing.SystemColors.Window;
            this.t_delivering.Location = new System.Drawing.Point(666, 370);
            this.t_delivering.Name = "t_delivering";
            this.t_delivering.Size = new System.Drawing.Size(135, 31);
            this.t_delivering.TabIndex = 11;
            this.t_delivering.Text = "Delivering";
            // 
            // t_delivered
            // 
            this.t_delivered.AutoSize = true;
            this.t_delivered.BackColor = System.Drawing.Color.Black;
            this.t_delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_delivered.ForeColor = System.Drawing.SystemColors.Window;
            this.t_delivered.Location = new System.Drawing.Point(669, 423);
            this.t_delivered.Name = "t_delivered";
            this.t_delivered.Size = new System.Drawing.Size(129, 31);
            this.t_delivered.TabIndex = 12;
            this.t_delivered.Text = "Delivered";
            // 
            // seeLocation
            // 
            this.seeLocation.Location = new System.Drawing.Point(816, 371);
            this.seeLocation.Name = "seeLocation";
            this.seeLocation.Size = new System.Drawing.Size(100, 32);
            this.seeLocation.TabIndex = 13;
            this.seeLocation.Text = "See Location";
            this.seeLocation.UseVisualStyleBackColor = true;
            this.seeLocation.Click += new System.EventHandler(this.seeLocation_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(897, 626);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(630, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(172, 24);
            this.label23.TabIndex = 15;
            this.label23.Text = "Tracking Order No:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(794, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 24);
            this.label24.TabIndex = 16;
            this.label24.Text = "1";
            // 
            // switchToUser
            // 
            this.switchToUser.Location = new System.Drawing.Point(12, 12);
            this.switchToUser.Name = "switchToUser";
            this.switchToUser.Size = new System.Drawing.Size(116, 23);
            this.switchToUser.TabIndex = 24;
            this.switchToUser.Text = "Switch To Admin";
            this.switchToUser.UseVisualStyleBackColor = true;
            this.switchToUser.Click += new System.EventHandler(this.switchToUser_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(897, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(75, 23);
            this.logOut.TabIndex = 25;
            this.logOut.Text = "LogOut";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // myOrders
            // 
            this.myOrders.AllowUserToAddRows = false;
            this.myOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.myOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.myOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.names,
            this.price,
            this.trackBtn});
            this.myOrders.Location = new System.Drawing.Point(13, 42);
            this.myOrders.Name = "myOrders";
            this.myOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.myOrders.RowHeadersVisible = false;
            this.myOrders.Size = new System.Drawing.Size(537, 596);
            this.myOrders.TabIndex = 26;
            this.myOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myOrders_CellContentClick);
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // names
            // 
            this.names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.names.HeaderText = "Product Name";
            this.names.Name = "names";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // trackBtn
            // 
            this.trackBtn.HeaderText = "Track";
            this.trackBtn.Name = "trackBtn";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.myOrders);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.switchToUser);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.seeLocation);
            this.Controls.Add(this.t_delivered);
            this.Controls.Add(this.t_delivering);
            this.Controls.Add(this.t_packing);
            this.Controls.Add(this.t_processing);
            this.Controls.Add(this.t_payment);
            this.Controls.Add(this.t_confirm);
            this.Name = "Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.myOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label t_confirm;
        private System.Windows.Forms.Label t_payment;
        private System.Windows.Forms.Label t_processing;
        private System.Windows.Forms.Label t_packing;
        private System.Windows.Forms.Label t_delivering;
        private System.Windows.Forms.Label t_delivered;
        private System.Windows.Forms.Button seeLocation;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button switchToUser;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.DataGridView myOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn trackBtn;
    }
}