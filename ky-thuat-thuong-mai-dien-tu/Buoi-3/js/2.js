document.write('Hello World!');

//So sanh == va ===
var n=1, m="1";
if(n == m) {
    console.log('True');
} 
if (n === m){
    console.log('True');
}else
    console.log('false');

//Toan tu 3 cham (...)
var p1 = {ten: 'Ao thun', gia: 50}
console.log(p1);
// var p2 = p1;
var p2 = {...p1}
p2.gia = 70;
console.log(p1);
console.log(p2);

//Bắt đối tượng
// var btn = document.getElementByTagName('btn-no1');
// var btn = document.getElementByClassName('btn-no1');
// var btn = document.getElementById('btn-no1');
var btn = document.querySelector('.btn-no1');
console.log(btn);

var khoi = document.querySelector('.khoi');
//Sự kiện click
function showAlert(){
    // alert('Transform');
    // khoi.classList.add('transform');
    khoi.classList.toggle('transform');
}