using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionState
{
	public partial class ConfirmProduct : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Retrieve the session variables
			ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
			ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
			txtProduct.Text = Session["strProduct"].ToString();
			txtDescription.Text = Session["strDescription"].ToString();
			txtImage.Text = Session["strImage"].ToString();
			Decimal decPrice = Convert.ToDecimal(Session["decPrice"]);
			txtPrice.Text = decPrice.ToString("c");
			txtNumberInStock.Text = Session["bytNumberInStock"].ToString();
			txtNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
			txtReorderLevel.Text = Session["bytReorderLevel"].ToString();
			//Compute and display the value in stock and the value on order 
			Byte bytNumberInStock = Convert.ToByte(Session["bytNumberInStock"]);
			Byte bytNumberOnOrder = Convert.ToByte(Session["bytNumberOnOrder"]);
			Decimal decValueInStock = decPrice * bytNumberInStock;
			Decimal decValueOnOrder = decPrice * bytNumberOnOrder;
			txtNumberInStock.Text = decValueInStock.ToString("c");
			txtNumberOnOrder.Text = decValueOnOrder.ToString("c");
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{

		}

		protected void btnBack_Click(object sender, EventArgs e)
		{

		}
	}
}