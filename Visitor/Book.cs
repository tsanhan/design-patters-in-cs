using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Book : ItemElement
    {


    private int price;
    private String isbnNumber;

    public Book(int cost, String isbn)
    {
        this.price = cost;
        this.isbnNumber = isbn;
    }

    public int getPrice()
    {
        return price;
    }

    public String getIsbnNumber()
    {
        return isbnNumber;
    }

    
    public int accept(IShoppingCartVisitor visitor)
    {
        return visitor.visit(this);
    }

}
}
