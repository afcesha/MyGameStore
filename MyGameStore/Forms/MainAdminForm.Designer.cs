namespace MyGameStore.Forms
{
    partial class MainAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            hellolabel = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            selectTable = new System.Windows.Forms.ToolStripSplitButton();
            clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectClient = new System.Windows.Forms.ToolStripMenuItem();
            productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectProduct = new System.Windows.Forms.ToolStripMenuItem();
            activationServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            diliveryServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            selectActivationService = new System.Windows.Forms.ToolStripMenuItem();
            selectDeliveryService = new System.Windows.Forms.ToolStripMenuItem();
            selectDelivery = new System.Windows.Forms.ToolStripMenuItem();
            selectOrder = new System.Windows.Forms.ToolStripMenuItem();
            selectOrderDetails = new System.Windows.Forms.ToolStripMenuItem();
            selectSupplier = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // hellolabel
            // 
            hellolabel.AutoSize = true;
            hellolabel.Location = new System.Drawing.Point(56, 43);
            hellolabel.Name = "hellolabel";
            hellolabel.Size = new System.Drawing.Size(0, 15);
            hellolabel.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { selectTable });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // selectTable
            // 
            selectTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            selectTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { clientToolStripMenuItem, productToolStripMenuItem, activationServiceToolStripMenuItem, diliveryServiceToolStripMenuItem, deliveryToolStripMenuItem, orderToolStripMenuItem, orderDetailsToolStripMenuItem, toolStripMenuItem1 });
            selectTable.Image = (System.Drawing.Image)resources.GetObject("selectTable.Image");
            selectTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            selectTable.Name = "selectTable";
            selectTable.Size = new System.Drawing.Size(72, 22);
            selectTable.Text = "Таблицы";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectClient });
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            clientToolStripMenuItem.Text = "Client";
            // 
            // selectClient
            // 
            selectClient.Name = "selectClient";
            selectClient.Size = new System.Drawing.Size(141, 22);
            selectClient.Text = "Посмотреть";
            selectClient.Click += selectClient_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectProduct });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            productToolStripMenuItem.Text = "Product";
            // 
            // selectProduct
            // 
            selectProduct.Name = "selectProduct";
            selectProduct.Size = new System.Drawing.Size(180, 22);
            selectProduct.Text = "Посмотреть";
            selectProduct.Click += selectProduct_Click;
            // 
            // activationServiceToolStripMenuItem
            // 
            activationServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectActivationService });
            activationServiceToolStripMenuItem.Name = "activationServiceToolStripMenuItem";
            activationServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            activationServiceToolStripMenuItem.Text = "ActivationService";
            // 
            // diliveryServiceToolStripMenuItem
            // 
            diliveryServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectDeliveryService });
            diliveryServiceToolStripMenuItem.Name = "diliveryServiceToolStripMenuItem";
            diliveryServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            diliveryServiceToolStripMenuItem.Text = "DeliveryService";
            // 
            // deliveryToolStripMenuItem
            // 
            deliveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectDelivery });
            deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            deliveryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectOrder });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            orderToolStripMenuItem.Text = "Order";
            // 
            // orderDetailsToolStripMenuItem
            // 
            orderDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectOrderDetails });
            orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            orderDetailsToolStripMenuItem.Text = "OrderDetails";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectSupplier });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            toolStripMenuItem1.Text = "Supplier";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(776, 410);
            dataGridView1.TabIndex = 3;
            // 
            // selectActivationService
            // 
            selectActivationService.Name = "selectActivationService";
            selectActivationService.Size = new System.Drawing.Size(180, 22);
            selectActivationService.Text = "Посмотреть";
            selectActivationService.Click += selectActivationService_Click;
            // 
            // selectDeliveryService
            // 
            selectDeliveryService.Name = "selectDeliveryService";
            selectDeliveryService.Size = new System.Drawing.Size(180, 22);
            selectDeliveryService.Text = "Посмотреть";
            selectDeliveryService.Click += selectDeliveryService_Click;
            // 
            // selectDelivery
            // 
            selectDelivery.Name = "selectDelivery";
            selectDelivery.Size = new System.Drawing.Size(180, 22);
            selectDelivery.Text = "Посмотреть";
            selectDelivery.Click += selectDelivery_Click;
            // 
            // selectOrder
            // 
            selectOrder.Name = "selectOrder";
            selectOrder.Size = new System.Drawing.Size(141, 22);
            selectOrder.Text = "Посмотреть";
            selectOrder.Click += selectOrder_Click;
            // 
            // selectOrderDetails
            // 
            selectOrderDetails.Name = "selectOrderDetails";
            selectOrderDetails.Size = new System.Drawing.Size(141, 22);
            selectOrderDetails.Text = "Посмотреть";
            selectOrderDetails.Click += selectOrderDetails_Click;
            // 
            // selectSupplier
            // 
            selectSupplier.Name = "selectSupplier";
            selectSupplier.Size = new System.Drawing.Size(180, 22);
            selectSupplier.Text = "Посмотреть";
            selectSupplier.Click += selectSupplier_Click;
            // 
            // MainAdminForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(hellolabel);
            Name = "MainAdminForm";
            Text = "MainAdminForm";
            Load += MainAdminForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label hellolabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton selectTable;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activationServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diliveryServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectClient;
        private System.Windows.Forms.ToolStripMenuItem selectProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem selectActivationService;
        private System.Windows.Forms.ToolStripMenuItem selectDeliveryService;
        private System.Windows.Forms.ToolStripMenuItem selectDelivery;
        private System.Windows.Forms.ToolStripMenuItem selectOrder;
        private System.Windows.Forms.ToolStripMenuItem selectOrderDetails;
        private System.Windows.Forms.ToolStripMenuItem selectSupplier;
    }
}