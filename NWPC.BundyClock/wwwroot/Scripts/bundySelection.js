var bundyType = '';

function highlightButton(button) {
    // Remove highlight class from all buttons
    var buttons = document.querySelectorAll('.time-in, .time-out, .lunch-in, .lunch-out');
    buttons.forEach(function (btn) {
        btn.classList.remove('highlight');
    });

    // Add highlight class to the clicked button
    button.classList.add('highlight');

    // Set the string value based on the button clicked
    var buttonText = button.textContent.trim();

    switch (buttonText) {
        case 'Time In':
            bundyType = 'Time In';
            break;
        case 'Time Out':
            bundyType = 'Time Out';
            break;
        case 'Lunch In':
            bundyType = 'Lunch In';
            break;
        case 'Lunch Out':
            bundyType = 'Lunch Out';
            break;
        default:
            bundyType = '';
            break;
    }

    console.log(bundyType);
}

function getBundyType() {
    return bundyType;
}

function resetBundyType() {
    bundyType = '';
}
