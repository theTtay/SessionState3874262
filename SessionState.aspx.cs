using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionState
{
	public partial class SessionState : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
			
        }

		protected void btnConfirm_Click1(object sender, EventArgs e)
		{
			Session["ddlCategory"] = ddlCategory.SelectedValue;
			Session["ddlSupplier"] = ddlSupplier.SelectedValue;
			Session["strProduct"] = txtProduct.Text;
			Session["strDescription"] = txtDescription.Text;
			Session["strImage"] = txtImage.Text;
			Session["decPrice"] = txtPrice.Text;
			Session["bytNumberInStock"] = txtNumberInStock.Text;
			Session["bytNumberOnOrder"] = txtNumberOnOrder.Text;
			Session["bytReorderLevel"] = txtReorderLevel.Text;

			//Go to the confirmation page
			Response.Redirect("ConfirmProduct.aspx");
		}
	}
}