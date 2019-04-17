using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JoneEu
{
    public partial class FrmCadProduto : Form
    {
        //instaciando datatable
        DataTable dt = new DataTable();
        //instaciando dataSet
        DataSet ds = new DataSet();

        public FrmCadProduto()
        {
            //datatable dentro da gridcontrol
            InitializeComponent();
            dt.Columns.Add("PRO_MASKCOD", typeof(string));
            dt.Columns.Add("PRO_DESCRICAO", typeof(string));
            dt.Columns.Add("PRO_UNIDADE", typeof(string));
            dt.Columns.Add("PRO_VALOR", typeof(double));
            dt.Columns.Add("PRO_ESTOQUE", typeof(double));

            ds.Tables.Add(dt);
            gridControl1.DataSource = dt;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

           
            
            
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["PRO_MASKCOD"] = Funcoes.trataString(edPRO_MASKCOD.EditValue);
            dr["PRO_DESCRICAO"] = Funcoes.trataString(edPRO_DESCRICAO.EditValue);
            dr["PRO_UNIDADE"] = Funcoes.trataString(edPRO_UNIDADE.EditValue);
            dr["PRO_VALOR"] = Funcoes.trataDouble(edPRO_VALOR.EditValue);
            dr["PRO_ESTOQUE"] = Funcoes.trataDouble(edPRO_ESTOQUE.EditValue);

            dt.Rows.Add(dr);

            ds.WriteXml("ATA.XML");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            edPRO_MASKCOD.EditValue = "";
            edPRO_DESCRICAO.EditValue = "";
            edPRO_UNIDADE.EditValue = "";
            edPRO_VALOR.EditValue = "";
            edPRO_ESTOQUE.EditValue = "";
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("produto.xml"))
            {
                gridView1.RestoreLayoutFromXml("produto.xml");
            }
           
            if (System.IO.File.Exists("ATA.XML"))
            {
                ds.ReadXml("ATA.XML");
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (row == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Deseja ja era", "Del", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dt.Rows.Remove(row);
                }
                else
                {
                    return;
                }
                
            }
        }

        private void FrmCadProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml("produto.xml");
        }
    }
}
