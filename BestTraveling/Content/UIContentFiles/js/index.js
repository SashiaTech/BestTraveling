const ul = document.querySelector('#ul');
const sideBarIcons = document.querySelector(".sideBarIcons");
const toggle = document.querySelector('#toggle');
toggle.addEventListener('click', () => {
    const menuBar = document.querySelector('#menuBar');
    if (menuBar.style.left === "-1px") {
        menuBar.style.left = "0";
        //toggle.style.left = "250px";
        ul.style.display = "block";
        sideBarIcons.style.display = "none";
        menuBar.style.width = "300px";
    }
    else {
        menuBar.style.left = "-1px";
        //toggle.style.left = "150px";
        ul.style.display = "none";
        sideBarIcons.style.display = "block";
        menuBar.style.width = "70px";
    }
})
let anchor_Design = document.getElementsByClassName('anchor-design');
Array.from(anchor_Design).forEach((Element, index) => {
    let rytArrowBtn = document.getElementsByClassName('rytArrowBtn');
    Element.addEventListener('click', () => {
        let submenu = document.getElementsByClassName("submenu");
        if (submenu[index].style.maxHeight != "300px") {
            Array.from(rytArrowBtn).forEach((Element1) => {
                Element1.className = "fa fa-angle-right rytArrowBtn";
            })
            rytArrowBtn[index].className = "fa fa-angle-down rytArrowBtn";
            Array.from(submenu).forEach((Element) => {
                Element.style.maxHeight = "0px";
            })
            submenu[index].style.maxHeight = "300px";
        }
        else {
            submenu[index].style.maxHeight = "0px";
            rytArrowBtn[index].className = "fa fa-angle-right rytArrowBtn";
            // submenu[index].style.overflow = "hidden";
        }
    });
});