#include <string>
#include <iostream>

using namespace std;

class Product
{
public:
    Product() {}

    virtual string getProduct()
    {
        return "Product";
    };
};

class ElectronicProduct : public Product
{
public:
    ElectronicProduct() {}

    string getProduct()
    {
        return "ElectronicProduct";
    }
};

class BookProduct : public Product
{
public:
    BookProduct() {}

    string getProduct()
    {
        return "BookProduct";
    }
};

class GroceryProduct : public Product
{
public:
    GroceryProduct() {}

    string getProduct()
    {
        return "GroceryProduct";
    }
};

class DisplayProduct
{
public:
    DisplayProduct() {}

    void display(Product *product)
    {
        cout << product->getProduct() << endl;
    }
};

int main()
{
    Product *electronicProduct = new ElectronicProduct();
    Product *bookProduct = new BookProduct();
    Product *groceryProduct = new GroceryProduct();
    DisplayProduct displayProduct;

    displayProduct.display(electronicProduct);
    displayProduct.display(bookProduct);
    displayProduct.display(groceryProduct);

    return 0;
}