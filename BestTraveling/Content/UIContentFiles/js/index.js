const ul = document.querySelector('#ul');
const sideBarIcons = document.querySelector(".sideBarIcons");
const toggle = document.querySelector('#toggle');
toggle.addEventListener('click', () => {
    const menuBar = document.querySelector('#menuBar');
    if (menuBar.style.left === "-1px") {
        menuBar.style.left = "0";
        toggle.style.left = "250px";
        ul.style.display = "block";
        sideBarIcons.style.display = "none";
        menuBar.style.width = "300px";
    }
    else {
        menuBar.style.left = "-1px";
        toggle.style.left = "150px";
        ul.style.display = "none";
        sideBarIcons.style.display = "block";
        menuBar.style.width = "70px";
    }
})
//function for dropdowns and font awesome icon-changer collapse other dwopdowns on single click
const rytArrowBtn = document.getElementsByClassName('rytArrowBtn');
Array.from(rytArrowBtn).forEach((Element, index) => {
    Element.addEventListener('click', (e) => {
        let submenu = document.getElementsByClassName("submenu");
        if (e.target.className === "fa fa-angle-right rytArrowBtn") {
            Array.from(rytArrowBtn).forEach((Element1) => {
                Element1.className = "fa fa-angle-right rytArrowBtn";
            })
            e.target.className = "fa fa-angle-down rytArrowBtn";
            Array.from(submenu).forEach((Element) => {
                Element.style.display = "none";
            })
            submenu[index].style.display = "block";
        }
       else {
          Array.from(rytArrowBtn).forEach((Element1) => {
              Element1.className = "fa fa-angle-right rytArrowBtn";
          })
            e.target.className = "fa fa-angle-right rytArrowBtn";
            Array.from(submenu).forEach((Element) => {
                Element.style.display = "none";
            })
            submenu[index].style.display = "none";
        }
    });
});

//let li_collapse = document.getElementsByClassName('li_collapse');
//Array.from(li_collapse).forEach((Element, index) => {
//    let lftArrowBtn = document.getElementsByClassName('lftArrowBtn');
//    Element.addEventListener('click', () => {
//        let submenu1 = document.getElementsByClassName("submenu1");
//        if (submenu1[index].style.display == "none") {
//            Array.from(lftArrowBtn).forEach((Element1) => {
//                Element1.className = "fas fa-angle-right lftArrowBtn";
//            })
//            lftArrowBtn[index].className = "fas fa-angle-down lftArrowBtn";
//            console.log(submenu1[index]);
//            Array.from(submenu1).forEach((Element) => {
//                Element.style.display = "none";
//            })
//            submenu1[index].style.display = "block";
//        }
//        else {
//            Array.from(lftArrowBtn).forEach((Element1) => {
//                Element1.className = "fas fa-angle-right lftArrowBtn";
//            })

//            Array.from(submenu1).forEach((Element) => {
//                Element.style.display = "none";
//            })
//        }
//    });
//});