const toggle = document.querySelector('#toggle');
const ul_list = document.querySelector('#ul');
const sideBarIcons = document.querySelector(".sideBarIcons");
window.addEventListener("resize", () => {
    let windowSize = window.innerWidth;
    if (windowSize > 768) {
        menuBar.style.width = "300px";
        ul_list.style.display = "block";
        sideBarIcons.style.display = "none";
    }
});
toggle.addEventListener('click', toggler);
function toggler(e) {
    const menuBar = document.querySelector('#menuBar');
    const query = window.matchMedia("(max-width: 768px)")
    if (query.matches) {
        if (menuBar.style.width === "250px") {
            menuBar.style.width = "0px";
            ul_list.style.display = "none";
            sideBarIcons.style.display = "none";
        }
        else {
            menuBar.classList.remove("win");
            menuBar.style.width = "250px";
            ul_list.style.display = "block";
            sideBarIcons.style.display = "none";
        }
    }
    else {
        if (menuBar.style.width === "45px") {
            menuBar.style.width = "300px";
            ul_list.style.display = "block";
            sideBarIcons.style.display = "none";
        }
        else {
            menuBar.style.width = "45px";
            ul_list.style.display = "none";
            sideBarIcons.style.display = "block";
        }
    }
}

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
            
        }
    });
});