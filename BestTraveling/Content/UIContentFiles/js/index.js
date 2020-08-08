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
//function for dropdowns and font awesome icon-changer collapse other dwopdowns on single click
let li_collapse = document.getElementsByClassName('li_collapse');
Array.from(li_collapse).forEach((Element, index) => {
    let rytArrowBtn = document.getElementsByClassName('rytArrowBtn');
    Element.addEventListener('click', () => {
        let submenu = document.getElementsByClassName("submenu");
        if (submenu[index].style.display === "none") {
            Array.from(rytArrowBtn).forEach((Element1) => {
                Element1.className = "fa fa-angle-right rytArrowBtn";
            })
            rytArrowBtn[index].className = "fa fa-angle-down rytArrowBtn";
            Array.from(submenu).forEach((Element) => {
                Element.style.display = "none";
            })
            submenu[index].style.display = "block";
        }
        else {
            submenu[index].style.display = "none";
            rytArrowBtn[index].className = "fa fa-angle-right rytArrowBtn";
        }
    });
});