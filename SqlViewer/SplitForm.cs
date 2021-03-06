using SqlViewer.Dal;
using SqlViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class SplitForm : Form
    {
        private Lazy<Database> usingDatabase;
        public SplitForm()
        {
            InitializeComponent();
            Init();
        }
        private void Init() => LoadDatabases();

        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        private void SplitForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            usingDatabase = new Lazy<Database>(() => CbDatabases.SelectedItem as Database);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            ClearOutput();
            try
            {
                ShowResult();
            }
            catch (Exception ex)
            {
                LbMessage.Text = ex.Message;
                TcOutput.SelectedTab = TpMessage;
            }
        }

        private void ShowResult()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            OutputResult result = RepositoryFactory.GetRepository().ExecuteCommand(TbQuery.Text, usingDatabase.Value);
            stopWatch.Stop();
            result.ElapsedTime = stopWatch.Elapsed;
            if (result.Data != null)
            {
                ShowTables(result);
                TcOutput.SelectedTab = TpResult;
            }
            else
            {
                TcOutput.SelectedTab = TpMessage;
            }
            result.Message += $"Completion time: {result.ElapsedTime.TotalMilliseconds} ms.";
            LbMessage.Text = result.Message;
        }

        private void ShowTables(OutputResult result)
        {
            foreach (DataTable dt in result.Data.Tables)
            {
                FlpResult.Controls.Add(new DataGridView
                {
                    ReadOnly = true,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dt,
                    Width = FlpResult.Width - 30
                });
                result.Message += $"Selected {dt.Rows.Count} rows.\n\n";
            }
        }

        private void ClearOutput()
        {
            LbMessage.Text = "";
            FlpResult.Controls.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadDatabases();

    }
}
