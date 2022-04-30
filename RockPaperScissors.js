const getUserChoice = userInput => {
  userInput = userInput.toLowerCase();
  if (userInput === 'rock' || userInput === 'paper' || userInput === 'scissors' || userInput === 'bomb') {
    return userInput;
  } else {
    console.log('Error: Invalid Entry');
  }
};

const getComputerChoice = () => {
  let randNum = Math.floor(Math.random() * 3);
  switch (randNum) {
    case 0:
      return 'rock';
      break;
    case 1:
      return 'paper';
      break;
    case 2:
      return 'scissors';
      break;
  }
};

const determineWinner = (userChoice, computerChoice) => {
  if (userChoice === computerChoice) {
    return `You chose: ${userChoice}. AI chose: ${computerChoice}. It's a tie!`;
  } else if (userChoice === 'rock') {
    if (computerChoice === 'paper') {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. AI wins!`;
    } else {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. You win!`;
    }
  } else if (userChoice === 'paper') {
    if (computerChoice === 'scissors') {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. AI wins!`;
    } else {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. You win!`;
    }
  } else if (userChoice === 'scissors') {
    if (computerChoice === 'rock') {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. AI wins!`;
    } else {
      return `You chose: ${userChoice}. AI chose: ${computerChoice}. You win!`;
    }
  } else if (userChoice === 'bomb') {
    return `You chose: ${userChoice}. AI chose: ${computerChoice}. You win!`;
  }
};

const playGame = () => {
  let userChoice = getUserChoice('bomb');
  let computerChoice = getComputerChoice();
  console.log(determineWinner(userChoice, computerChoice));
};

playGame();
