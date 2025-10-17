namespace Flight_Ticket_2
{
    partial class FrmMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTicketDetail = new System.Windows.Forms.Panel();
            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtArriveTime = new System.Windows.Forms.TextBox();
            this.txtDepartTime = new System.Windows.Forms.TextBox();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTicketDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnlTicketDetail
            // 
            this.pnlTicketDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTicketDetail.BackgroundImage = global::Flight_Ticket_2.Properties.Resources.bg_form_main_1_;
            this.pnlTicketDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTicketDetail.Controls.Add(this.btnMyTickets);
            this.pnlTicketDetail.Controls.Add(this.btnDeleteFlight);
            this.pnlTicketDetail.Controls.Add(this.btnAddFlight);
            this.pnlTicketDetail.Controls.Add(this.txtPrice);
            this.pnlTicketDetail.Controls.Add(this.label8);
            this.pnlTicketDetail.Controls.Add(this.btnBook);
            this.pnlTicketDetail.Controls.Add(this.label7);
            this.pnlTicketDetail.Controls.Add(this.txtSeat);
            this.pnlTicketDetail.Controls.Add(this.txtArriveTime);
            this.pnlTicketDetail.Controls.Add(this.txtDepartTime);
            this.pnlTicketDetail.Controls.Add(this.txtArrive);
            this.pnlTicketDetail.Controls.Add(this.txtDepart);
            this.pnlTicketDetail.Controls.Add(this.txtFlightID);
            this.pnlTicketDetail.Controls.Add(this.label6);
            this.pnlTicketDetail.Controls.Add(this.label5);
            this.pnlTicketDetail.Controls.Add(this.label4);
            this.pnlTicketDetail.Controls.Add(this.label3);
            this.pnlTicketDetail.Controls.Add(this.label2);
            this.pnlTicketDetail.Controls.Add(this.label1);
            this.pnlTicketDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTicketDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketDetail.Name = "pnlTicketDetail";
            this.pnlTicketDetail.Size = new System.Drawing.Size(982, 450);
            this.pnlTicketDetail.TabIndex = 1;
            this.pnlTicketDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTicketDetail_Paint);
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnMyTickets.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTickets.Location = new System.Drawing.Point(763, 323);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Size = new System.Drawing.Size(139, 32);
            this.btnMyTickets.TabIndex = 16;
            this.btnMyTickets.Text = "My Tickets";
            this.btnMyTickets.UseVisualStyleBackColor = false;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteFlight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteFlight.Location = new System.Drawing.Point(453, 323);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(139, 32);
            this.btnDeleteFlight.TabIndex = 17;
            this.btnDeleteFlight.Text = "Delete Flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFlight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddFlight.Location = new System.Drawing.Point(294, 323);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(139, 32);
            this.btnAddFlight.TabIndex = 18;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(617, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(183, 31);
            this.txtPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price";
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(617, 323);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(139, 32);
            this.btnBook.TabIndex = 13;
            this.btnBook.Text = "Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "----------------------->";
            // 
            // txtSeat
            // 
            this.txtSeat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat.Location = new System.Drawing.Point(165, 324);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.ReadOnly = true;
            this.txtSeat.Size = new System.Drawing.Size(100, 31);
            this.txtSeat.TabIndex = 11;
            // 
            // txtArriveTime
            // 
            this.txtArriveTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArriveTime.Location = new System.Drawing.Point(617, 244);
            this.txtArriveTime.Name = "txtArriveTime";
            this.txtArriveTime.ReadOnly = true;
            this.txtArriveTime.Size = new System.Drawing.Size(285, 31);
            this.txtArriveTime.TabIndex = 10;
            // 
            // txtDepartTime
            // 
            this.txtDepartTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartTime.Location = new System.Drawing.Point(136, 244);
            this.txtDepartTime.Name = "txtDepartTime";
            this.txtDepartTime.ReadOnly = true;
            this.txtDepartTime.Size = new System.Drawing.Size(254, 31);
            this.txtDepartTime.TabIndex = 9;
            // 
            // txtArrive
            // 
            this.txtArrive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrive.Location = new System.Drawing.Point(617, 153);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.ReadOnly = true;
            this.txtArrive.Size = new System.Drawing.Size(285, 31);
            this.txtArrive.TabIndex = 8;
            // 
            // txtDepart
            // 
            this.txtDepart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepart.Location = new System.Drawing.Point(136, 153);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.ReadOnly = true;
            this.txtDepart.Size = new System.Drawing.Size(254, 31);
            this.txtDepart.TabIndex = 7;
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.Location = new System.Drawing.Point(136, 53);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.ReadOnly = true;
            this.txtFlightID.Size = new System.Drawing.Size(170, 31);
            this.txtFlightID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remain Seat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrive Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depart Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrive Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depart Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pnlTicketDetail);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTicketDetail.ResumeLayout(false);
            this.pnlTicketDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlTicketDetail;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtArriveTime;
        private System.Windows.Forms.TextBox txtDepartTime;
        private System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMyTickets;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnAddFlight;
    }
}