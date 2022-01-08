let offset = 0;
const sliderLine = document.querySelector('.slider-line');

document.querySelector('.slider-next').addEventListener('click', function(){
    offset = offset + 290;
    if (offset > 870) {
        offset = 0;
    }
    sliderLine.style.left = -offset + 'px';
});

document.querySelector('.slider-prev').addEventListener('click', function () {
    offset = offset - 290;
    if (offset < 0) {
        offset = 870;
    }
    sliderLine.style.left = -offset + 'px';
});

const sliderLine1 = document.querySelector('.slider-line1');

document.querySelector('.slider-next1').addEventListener('click', function(){
    offset = offset + 290;
    if (offset > 870) {
        offset = 0;
    }
    sliderLine1.style.left = -offset + 'px';
});

document.querySelector('.slider-prev1').addEventListener('click', function () {
    offset = offset - 290;
    if (offset < 0) {
        offset = 870;
    }
    sliderLine1.style.left = -offset + 'px';
});

const sliderLine2 = document.querySelector('.slider-line2');

document.querySelector('.slider-next2').addEventListener('click', function(){
    offset = offset + 290;
    if (offset > 870) {
        offset = 0;
    }
    sliderLine2.style.left = -offset + 'px';
});

document.querySelector('.slider-prev2').addEventListener('click', function () {
    offset = offset - 290;
    if (offset < 0) {
        offset = 870;
    }
    sliderLine2.style.left = -offset + 'px';
});