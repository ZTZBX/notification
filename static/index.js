function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
 }

async function close()
{

    await sleep(8000);
    $(".toast").toast("hide");
}

function toastAdd()
{
    $(".toast").toast("show");
    close();
}


$(function () {
    
    window.addEventListener('message', function (event) {
        var item = event.data;

        if (item.showNot == true) {
            document.getElementById("title").innerText = item.title;
            document.getElementById("sender").innerText = item.sender;
            document.getElementById("message").innerText = item.message;
            toastAdd();
        }
    });
});