// toggle effect for menuBar
const toggle = document.querySelector('#toggle1');
toggle.addEventListener('click', () => {
    const menuBar = document.querySelector('#menuBar');
    if (menuBar.style.left === "-170px") {
        menuBar.style.left = "0";
    }
    else {
        menuBar.style.left = "-170px";
    }
})
const lftArrowBtn = document.getElementsByClassName('lftArrowBtn');
Array.from(lftArrowBtn).forEach((Element) => {
    Element.addEventListener('click', () => {
        let elementParent = Element.parentElement;
        let elementParent1 = elementParent.parentElement;
        // console.log(elementParent1);
        // console.log(elementParent1.children[1]);
        // console.log(Element);
        const elementChild = elementParent1.children[1];
        // console.log(elementChild);

        if (elementChild.style.display === "block") {
            elementChild.style.display = "none";
        } else {
            elementChild.style.display = "block";
        }
    });
});






