window.onload = function () {
  const ballsContainer = document.getElementById('balls');
  const slider = document.getElementById('slider');
  const guessDisplay = document.getElementById('guess');
  const resultDisplay = document.getElementById('result');

  // Create 10 balls dynamically
  for (let i = 1; i <= 10; i++) {
    const ball = document.createElement('div');
    ball.classList.add('ball');
    ball.id = `ball-${i}`;
    ball.textContent = i;
    ballsContainer.appendChild(ball);
  }

  // Random number between 1 and 10
  const randomNumber = Math.floor(Math.random() * 10) + 1;
  console.log("Random Number (for debugging):", randomNumber);

  let attempts = 0;
  const maxAttempts = 6;

  // Update guess display on slider movement
  slider.addEventListener('input', () => {
    guessDisplay.textContent = slider.value;
  });

  // Check Guess Function
  window.checkGuess = function () {
    if (attempts >= maxAttempts) {
      resultDisplay.textContent = "Game Over! You've used all attempts.";
      return;
    }

    const guess = parseInt(slider.value);
    attempts++;

    const guessedBall = document.getElementById(`ball-${guess}`);

    if (guess > randomNumber) {
      guessedBall.style.backgroundColor = 'red';
      resultDisplay.textContent = `Too High! Attempts left: ${maxAttempts - attempts}`;
    } else if (guess < randomNumber) {
      guessedBall.style.backgroundColor = 'yellow';
      resultDisplay.textContent = `Too Low! Attempts left: ${maxAttempts - attempts}`;
    } else {
      guessedBall.style.backgroundColor = 'green';
      resultDisplay.textContent = `🎉 Correct! You guessed it in ${attempts} attempt(s)!`;
      slider.disabled = true;
    }

    // End game if max attempts reached
    if (attempts === maxAttempts && guess !== randomNumber) {
      resultDisplay.textContent = `Game Over! The correct number was ${randomNumber}.`;
      slider.disabled = true;
    }
  };
};
