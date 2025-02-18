import React, { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [expenses, setExpenses] = useState([]);

  useEffect(() => {
    axios.get('https://<your-function-app>.azurewebsites.net/api/expenses')
      .then(response => setExpenses(response.data));
  }, []);

  return (
    <div>
      <h1>Expenses</h1>
      {expenses.map(expense => (
        <div key={expense.id}>
          <p>{expense.description}: ${expense.amount}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
