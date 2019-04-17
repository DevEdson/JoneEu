namespace JoneEu
{
    partial class FrmCadProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edPRO_ESTOQUE = new DevExpress.XtraEditors.TextEdit();
            this.edPRO_VALOR = new DevExpress.XtraEditors.TextEdit();
            this.edPRO_UNIDADE = new DevExpress.XtraEditors.TextEdit();
            this.edPRO_DESCRICAO = new DevExpress.XtraEditors.TextEdit();
            this.edPRO_MASKCOD = new DevExpress.XtraEditors.TextEdit();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_ESTOQUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_VALOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_UNIDADE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_MASKCOD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 185);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 265);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnLimpar);
            this.panelControl1.Controls.Add(this.btnConfirmar);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.edPRO_ESTOQUE);
            this.panelControl1.Controls.Add(this.edPRO_VALOR);
            this.panelControl1.Controls.Add(this.edPRO_UNIDADE);
            this.panelControl1.Controls.Add(this.edPRO_DESCRICAO);
            this.panelControl1.Controls.Add(this.edPRO_MASKCOD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 185);
            this.panelControl1.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(270, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Estoque";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(95, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Preco";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(515, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Unidade";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(250, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Descricao";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(95, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Referencia";
            // 
            // edPRO_ESTOQUE
            // 
            this.edPRO_ESTOQUE.Location = new System.Drawing.Point(270, 152);
            this.edPRO_ESTOQUE.Name = "edPRO_ESTOQUE";
            this.edPRO_ESTOQUE.Size = new System.Drawing.Size(106, 20);
            this.edPRO_ESTOQUE.TabIndex = 14;
            // 
            // edPRO_VALOR
            // 
            this.edPRO_VALOR.Location = new System.Drawing.Point(95, 152);
            this.edPRO_VALOR.Name = "edPRO_VALOR";
            this.edPRO_VALOR.Size = new System.Drawing.Size(106, 20);
            this.edPRO_VALOR.TabIndex = 13;
            // 
            // edPRO_UNIDADE
            // 
            this.edPRO_UNIDADE.Location = new System.Drawing.Point(515, 56);
            this.edPRO_UNIDADE.Name = "edPRO_UNIDADE";
            this.edPRO_UNIDADE.Size = new System.Drawing.Size(106, 20);
            this.edPRO_UNIDADE.TabIndex = 12;
            // 
            // edPRO_DESCRICAO
            // 
            this.edPRO_DESCRICAO.Location = new System.Drawing.Point(250, 56);
            this.edPRO_DESCRICAO.Name = "edPRO_DESCRICAO";
            this.edPRO_DESCRICAO.Size = new System.Drawing.Size(225, 20);
            this.edPRO_DESCRICAO.TabIndex = 11;
            // 
            // edPRO_MASKCOD
            // 
            this.edPRO_MASKCOD.Location = new System.Drawing.Point(95, 56);
            this.edPRO_MASKCOD.Name = "edPRO_MASKCOD";
            this.edPRO_MASKCOD.Size = new System.Drawing.Size(106, 20);
            this.edPRO_MASKCOD.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(450, 150);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(558, 149);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ref.";
            this.gridColumn1.FieldName = "PRO_MASKCOD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 105;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descricao";
            this.gridColumn2.FieldName = "PRO_DESCRICAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 202;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Uni.";
            this.gridColumn3.FieldName = "PRO_UNIDADE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 172;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Valor";
            this.gridColumn4.FieldName = "PRO_VALOR";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 113;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Estoque";
            this.gridColumn5.FieldName = "PRO_ESTOQUE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 190;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(657, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "DelX";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCadProduto";
            this.Text = "FrmCadProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadProduto_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_ESTOQUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_VALOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_UNIDADE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_MASKCOD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit edPRO_ESTOQUE;
        private DevExpress.XtraEditors.TextEdit edPRO_VALOR;
        private DevExpress.XtraEditors.TextEdit edPRO_UNIDADE;
        private DevExpress.XtraEditors.TextEdit edPRO_DESCRICAO;
        private DevExpress.XtraEditors.TextEdit edPRO_MASKCOD;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}

