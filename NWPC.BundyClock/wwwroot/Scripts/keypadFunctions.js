function updateInput(value) {
    var input = document.getElementById('employeeInput');
    // Handle appending or deleting characters
    if (value === 'delete') {
        input.value = input.value.slice(0, -1); // Delete the last character
    } else {
        input.value += value; // Append the provided value
    }

    // Trigger a change event to simulate user input
    var event = new Event('input', {
        bubbles: true,
        cancelable: false,
    });
    input.dispatchEvent(event);
}

function toggleKeypad() {
    var numpad = document.getElementById('onScreenNumpad');
    var letterKeypad = document.getElementById('onScreenletterKeypad');

    if (numpad.classList.contains('hidden')) {
        // Switching from letter keypad to numpad
        numpad.classList.remove('hidden');
        letterKeypad.classList.add('hidden');
    } else {
        // Switching from numpad to letter keypad
        numpad.classList.add('hidden');
        letterKeypad.classList.remove('hidden');
    }
}

function deleteLast() {
    var input = document.getElementById('employeeInput');
    input.value = input.value.slice(0, -1);
    // Trigger a change event to simulate user input
    var event = new Event('input', {
        bubbles: true,
        cancelable: true,
    });
    input.dispatchEvent(event);
}

function appendToInput(value) {
    document.getElementById('employeeInput').value += value;
    // Trigger a change event to simulate user input
    var event = new Event('input', {
        bubbles: true,
        cancelable: true,
    });
    input.dispatchEvent(event);
}
