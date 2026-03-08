

import { calculateTotal, generateInvoice } from './cart.js';

// Store product objects in an array
const cart = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

// Generate invoice text
const invoice = generateInvoice(cart);

// Calculate total cart value
const totalAmount = calculateTotal(cart);

// Get output element
const outputElement = document.getElementById("output");

//Display formatted invoice using template literals
outputElement.textContent = `
========== INVOICE ==========
${invoice}

Total Cart Value: ₹${totalAmount}
=============================`;