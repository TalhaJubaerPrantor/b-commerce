namespace Pts
{
    partial class adminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.switchToUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.orderdItem = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.processing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.packing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delivering = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderdItem)).BeginInit();
            this.SuspendLayout();
            // 
            // switchToUser
            // 
            this.switchToUser.Location = new System.Drawing.Point(12, 12);
            this.switchToUser.Name = "switchToUser";
            this.switchToUser.Size = new System.Drawing.Size(116, 23);
            this.switchToUser.TabIndex = 1;
            this.switchToUser.Text = "Switch To User";
            this.switchToUser.UseVisualStyleBackColor = true;
            this.switchToUser.Click += new System.EventHandler(this.switchToUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Orders";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(897, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(75, 23);
            this.logOut.TabIndex = 21;
            this.logOut.Text = "LogOut";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // orderdItem
            // 
            this.orderdItem.AllowUserToAddRows = false;
            this.orderdItem.AllowUserToDeleteRows = false;
            this.orderdItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderdItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.orderdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.name,
            this.email,
            this.price,
            this.confirm,
            this.payment,
            this.processing,
            this.packing,
            this.delivering,
            this.map,
            this.delivered,
            this.update,
            this.delete});
            this.orderdItem.Location = new System.Drawing.Point(16, 76);
            this.orderdItem.Name = "orderdItem";
            this.orderdItem.RowHeadersVisible = false;
            this.orderdItem.Size = new System.Drawing.Size(950, 573);
            this.orderdItem.TabIndex = 22;
            this.orderdItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderdItem_CellContentClick);
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // confirm
            // 
            this.confirm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.confirm.HeaderText = "Confirm";
            this.confirm.Name = "confirm";
            this.confirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.confirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // payment
            // 
            this.payment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            this.payment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // processing
            // 
            this.processing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processing.HeaderText = "Processing";
            this.processing.Name = "processing";
            this.processing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // packing
            // 
            this.packing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packing.HeaderText = "Packing";
            this.packing.Name = "packing";
            this.packing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.packing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delivering
            // 
            this.delivering.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delivering.HeaderText = "Delivering";
            this.delivering.Name = "delivering";
            this.delivering.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delivering.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // map
            // 
            this.map.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.map.HeaderText = "Map";
            this.map.Name = "map";
            this.map.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // delivered
            // 
            this.delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delivered.HeaderText = "Delivered";
            this.delivered.Name = "delivered";
            this.delivered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delivered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // update
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.update.DefaultCellStyle = dataGridViewCellStyle1;
            this.update.HeaderText = "Update";
            this.update.Name = "update";
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.orderdItem);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.switchToUser);
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderdItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchToUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.DataGridView orderdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn processing;
        private System.Windows.Forms.DataGridViewCheckBoxColumn packing;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delivering;
        private System.Windows.Forms.DataGridViewTextBoxColumn map;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delivered;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}