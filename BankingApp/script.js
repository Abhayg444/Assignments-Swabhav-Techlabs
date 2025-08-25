class Person {
  constructor(name) {
    this.name = name;
  }
}

class Account {
  constructor(person) {
    this.person = person;
    this.balance = 0;
  }

  deposit(amount) {
    this.balance += amount;
  }

  withdraw(amount) {
    if (amount <= this.balance) {
      this.balance -= amount;
      return true;
    }
    alert("Insufficient Balance!");
    return false;
  }

  transfer(toAccount, amount) {
    if (this.withdraw(amount)) {
      toAccount.deposit(amount);
    }
  }
}

const accounts = [];

function createAccount() {
  const name = document.getElementById("personName").value.trim();
  if (name === "") {
    alert("Please enter a name.");
    return;
  }
  const person = new Person(name);
  const account = new Account(person);
  accounts.push(account);
  document.getElementById("personName").value = "";
  updateUI();
}

function deposit() {
  const index = document.getElementById("accountSelect").value;
  const amount = parseFloat(document.getElementById("amount").value);
  if (amount > 0) {
    accounts[index].deposit(amount);
    updateUI();
  }
}

function withdraw() {
  const index = document.getElementById("accountSelect").value;
  const amount = parseFloat(document.getElementById("amount").value);
  if (amount > 0) {
    accounts[index].withdraw(amount);
    updateUI();
  }
}

function transfer() {
  const fromIndex = document.getElementById("fromAccount").value;
  const toIndex = document.getElementById("toAccount").value;
  const amount = parseFloat(document.getElementById("transferAmount").value);

  if (fromIndex === toIndex) {
    alert("Cannot transfer to the same account!");
    return;
  }
  if (amount > 0) {
    accounts[fromIndex].transfer(accounts[toIndex], amount);
    updateUI();
  }
}

function updateUI() {
  const accountSelect = document.getElementById("accountSelect");
  const fromAccount = document.getElementById("fromAccount");
  const toAccount = document.getElementById("toAccount");
  const accountsList = document.getElementById("accountsList");

  accountSelect.innerHTML = "";
  fromAccount.innerHTML = "";
  toAccount.innerHTML = "";
  accountsList.innerHTML = "";

  accounts.forEach((acc, i) => {
    let option = `<option value="${i}">${acc.person.name} (Balance: $${acc.balance})</option>`;
    accountSelect.innerHTML += option;
    fromAccount.innerHTML += option;
    toAccount.innerHTML += option;
    accountsList.innerHTML += `<li><b>${acc.person.name}</b> - Balance: $${acc.balance}</li>`;
  });
}

