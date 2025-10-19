namespace Final_Project
{
    partial class FrmUser
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.pnlTicketDetail = new System.Windows.Forms.Panel();
            this.txtArriveTime = new System.Windows.Forms.TextBox();
            this.txtDepartTime = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.pnlTicketDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(648, 399);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(794, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 32);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(959, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "NOTE: WE SUPPORT FLIGHTS THROUGH THESE 4 CITIES: HO CHI MINH CITY (TPHCM), HA NOI" +
    " (HN), DA NANG (DN), HAI PHONG (HP)\r\n";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(479, 370);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(139, 32);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnMyTickets.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTickets.Location = new System.Drawing.Point(794, 352);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Size = new System.Drawing.Size(139, 32);
            this.btnMyTickets.TabIndex = 16;
            this.btnMyTickets.Text = "My Tickets";
            this.btnMyTickets.UseVisualStyleBackColor = false;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(648, 352);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(139, 32);
            this.btnBook.TabIndex = 13;
            this.btnBook.Text = "Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFlights.Location = new System.Drawing.Point(0, 458);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.Size = new System.Drawing.Size(982, 345);
            this.dgvFlights.TabIndex = 4;
            this.dgvFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlights_CellClick);
            // 
            // pnlTicketDetail
            // 
            this.pnlTicketDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTicketDetail.BackgroundImage = global::Final_Project.Properties.Resources.bg_form_main_1_;
            this.pnlTicketDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTicketDetail.Controls.Add(this.txtArriveTime);
            this.pnlTicketDetail.Controls.Add(this.txtDepartTime);
            this.pnlTicketDetail.Controls.Add(this.txtQuantity);
            this.pnlTicketDetail.Controls.Add(this.label10);
            this.pnlTicketDetail.Controls.Add(this.txtPrice);
            this.pnlTicketDetail.Controls.Add(this.label8);
            this.pnlTicketDetail.Controls.Add(this.txtSeat);
            this.pnlTicketDetail.Controls.Add(this.txtArrive);
            this.pnlTicketDetail.Controls.Add(this.txtDepart);
            this.pnlTicketDetail.Controls.Add(this.txtFlightID);
            this.pnlTicketDetail.Controls.Add(this.label6);
            this.pnlTicketDetail.Controls.Add(this.label5);
            this.pnlTicketDetail.Controls.Add(this.label4);
            this.pnlTicketDetail.Controls.Add(this.label3);
            this.pnlTicketDetail.Controls.Add(this.label2);
            this.pnlTicketDetail.Controls.Add(this.label1);
            this.pnlTicketDetail.Controls.Add(this.btnSearch);
            this.pnlTicketDetail.Controls.Add(this.btnLogout);
            this.pnlTicketDetail.Controls.Add(this.label9);
            this.pnlTicketDetail.Controls.Add(this.btnReload);
            this.pnlTicketDetail.Controls.Add(this.btnMyTickets);
            this.pnlTicketDetail.Controls.Add(this.btnBook);
            this.pnlTicketDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTicketDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketDetail.Name = "pnlTicketDetail";
            this.pnlTicketDetail.Size = new System.Drawing.Size(982, 452);
            this.pnlTicketDetail.TabIndex = 5;
            // 
            // txtArriveTime
            // 
            this.txtArriveTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArriveTime.Location = new System.Drawing.Point(611, 254);
            this.txtArriveTime.Name = "txtArriveTime";
            this.txtArriveTime.ReadOnly = true;
            this.txtArriveTime.Size = new System.Drawing.Size(283, 31);
            this.txtArriveTime.TabIndex = 45;
            // 
            // txtDepartTime
            // 
            this.txtDepartTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartTime.Location = new System.Drawing.Point(165, 254);
            this.txtDepartTime.Name = "txtDepartTime";
            this.txtDepartTime.ReadOnly = true;
            this.txtDepartTime.Size = new System.Drawing.Size(254, 31);
            this.txtDepartTime.TabIndex = 44;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(200, 399);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 32);
            this.label10.TabIndex = 42;
            this.label10.Text = "Quantity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(711, 59);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(183, 31);
            this.txtPrice.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Price";
            // 
            // txtSeat
            // 
            this.txtSeat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat.Location = new System.Drawing.Point(200, 352);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.ReadOnly = true;
            this.txtSeat.Size = new System.Drawing.Size(100, 31);
            this.txtSeat.TabIndex = 37;
            // 
            // txtArrive
            // 
            this.txtArrive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrive.Location = new System.Drawing.Point(609, 152);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(285, 31);
            this.txtArrive.TabIndex = 36;
            // 
            // txtDepart
            // 
            this.txtDepart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepart.Location = new System.Drawing.Point(165, 152);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(254, 31);
            this.txtDepart.TabIndex = 35;
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.Location = new System.Drawing.Point(165, 52);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.ReadOnly = true;
            this.txtFlightID.Size = new System.Drawing.Size(170, 31);
            this.txtFlightID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Remain Seat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Arrive Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Depart Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Arrive Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Depart Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Flight";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.pnlTicketDetail);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP Airlines (Customer)";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.pnlTicketDetail.ResumeLayout(false);
            this.pnlTicketDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnMyTickets;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Panel pnlTicketDetail;
        private System.Windows.Forms.TextBox txtArriveTime;
        private System.Windows.Forms.TextBox txtDepartTime;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}