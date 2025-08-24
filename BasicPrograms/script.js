// Show the first tab by default
document.addEventListener("DOMContentLoaded", () => {
  openTab("prime");
});

// Function to switch tabs
function openTab(tabId) {
  let tabs = document.querySelectorAll(".tab");
  tabs.forEach(tab => tab.classList.remove("active"));
  document.getElementById(tabId).classList.add("active");
}

// Prime Checker
function checkPrime() {
  let num = parseInt(document.getElementById("primeInput").value);
  let result = document.getElementById("primeResult");

  if (isNaN(num)) {
    result.innerText = "Please enter a valid number.";
    return;
  }

  if (num <= 1) {
    result.innerText = num + " is NOT a prime number.";
    return;
  }

  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) {
      result.innerText = num + " is NOT a prime number.";
      return;
    }
  }
  result.innerText = num + " is a PRIME number.";
}

// Fibonacci Sum
function calculateFibSum() {
  let n = parseInt(document.getElementById("fibInput").value);
  let result = document.getElementById("fibResult");

  if (isNaN(n) || n < 0) {
    result.innerText = "Please enter a valid positive number.";
    return;
  }

  let a = 0, b = 1, sum = 0;

  for (let i = 1; i <= n; i++) {
    sum += a;
    let temp = a + b;
    a = b;
    b = temp;
  }

  result.innerText = "Sum of first " + n + " Fibonacci numbers = " + sum;
}

// Even, Odd, Zero Counter
function countNumbers() {
  let input = document.getElementById("numInput").value;
  let result = document.getElementById("countResult");

  if (!input.trim()) {
    result.innerText = "Please enter numbers separated by commas.";
    return;
  }

  let numbers = input.split(",").map(x => parseInt(x.trim())).filter(x => !isNaN(x));

  let even = 0, odd = 0, zero = 0;

  numbers.forEach(num => {
    if (num === 0) {
      zero++;
    } else if (num % 2 === 0) {
      even++;
    } else {
      odd++;
    }
  });

  result.innerText = "Even: " + even + ", Odd: " + odd + ", Zeros: " + zero;
}
