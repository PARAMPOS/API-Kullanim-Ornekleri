$(".list-group-item > p").click((event) => {
    if (event.target.parentElement.classList.contains("active"))
        slideUpMenu(event.target.parentElement);
    else
        slideDownMenu(event.target.parentElement);
});
function slideUpMenu(target) {
    target.classList.remove("active");
    target.querySelector(".toggle-icon").classList.remove("rotate");
    $(target.querySelector("ul")).slideUp();
}
function slideDownMenu(target) {
    document.querySelectorAll(".list-group-item.parent-item").forEach(item => {
        item.classList.remove("active");
        item.querySelector(".toggle-icon").classList.remove("rotate");
        $(item.querySelector("ul")).slideUp();
    });
    target.classList.add("active");
    target.querySelector(".toggle-icon").classList.add("rotate");
    $(target.querySelector("ul")).slideDown();
}
$(".list-group-item > ul > li").click((event) => {
    event.stopPropagation();
    $(".list-group-item > ul > li").removeClass("active-subitem");
    $(event.target).addClass("active-subitem");
    event.target.querySelector("a")?.click();
});
document.addEventListener("DOMContentLoaded", () => {
    $(".list-group-item > ul").hide();
    const menu = document.querySelector(`nav > ul > li:nth-child(${menuNo})`);
    menu.classList.add("active");
    menu.querySelector(".toggle-icon").classList.add("rotate");
    menu.querySelector(`ul > li:nth-child(${subMenuNo})`).classList.add("active-subitem");
    menu.querySelector("ul").style = "";
});