
// Arrow function to calculate total cart value
export const calculateTotal = (products) => {
    return products.reduce((total,product) => {
        return total + (product.price * product.quantity);
    },0);
};

// Arrow function to generate invoice lines
export const generateInvoice = (products) => {
    return  products.map(product => {
      return `
 Product: ${product.name}
      
    Price: ₹${product.price}
    Quantity: ${product.quantity}
    Subtotal: ₹${product.price * product.quantity}`
    }).join("\n");
};

