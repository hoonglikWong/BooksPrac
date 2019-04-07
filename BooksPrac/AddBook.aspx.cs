using BooksPrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BooksPrac
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void fvBook_InsertItem()
        {

            Book item = new Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                BooksInventoryEntities _db = new BooksInventoryEntities();
                _db.Books.Add(item);
                _db.SaveChanges();
                Response.Redirect("/ViewBooks.aspx");
            }
        }

        protected void fvBook_ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if(e.CommandName == "Cancel")
            {
                Response.Redirect("/ViewBooks.aspx");
            }
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
    }
}