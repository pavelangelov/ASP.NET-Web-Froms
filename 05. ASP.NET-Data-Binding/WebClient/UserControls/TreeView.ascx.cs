using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.Models;
using WebClient.Presenters;
using WebClient.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace WebClient.UserControls
{
    [PresenterBinding(typeof(TreeViewPresenter))]
    public partial class TreeView : MvpUserControl<TreeViewModel>, ITreeView
    {
        public event EventHandler PageLoad;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.PageLoad?.Invoke(sender, e);
            this.XmlDataSource.DataFile = this.Model.XmlFilePath;
            this.XmlDataSource.DataBind();
            this.XmlTreeView.DataBind();
        }

        // TODO: Fix this in future :)
        protected void XmlTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (this.XmlTreeView.SelectedNode.Expanded == true)
            {
                this.XmlTreeView.SelectedNode.Collapse();
            }
            else if (this.XmlTreeView.SelectedNode.Expanded == false)
            {
                this.XmlTreeView.SelectedNode.Expand();
            }
        }
    }
}