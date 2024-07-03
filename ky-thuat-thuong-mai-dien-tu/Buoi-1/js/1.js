var login = document.querySelector('.login-form');
console.log(login);
function showLoginForm(){
    login.classList.add('active');
    fr.classList.add('active');
}
var fr = document.querySelector('form');
function doLogin(){
    let username = document.getElementById('username').value;
    let password = document.getElementById('password').value;
    if(username == 'admin' && password =='admin'){
        window.location.href("https://youtube.com");
    }
    else{
        alert('Sai tài khoản hoặc mật khẩu');
        function showLoginForm(){
            login.classList.add('active')
        }
    }
}