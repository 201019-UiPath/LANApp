function GetAllParents() {
    fetch('')
        .then(response => response.json())
        .then(result => {
            document.querySelectorAll('#parents tbody tr').forEach(element => element.remove())
            let table = document.querySelectorAll('#parents tbody');
            for (let p = 0; p < result.length; ++p) {
                let row = table.insertRow(table.rows.length);

                let pnCell = row.insertCell(0);
                pnCell.innerHTML = result[p].parentName;

                let pCell = row.insertCell(1);
                pCell.innerHTML = result[p].phoneNumber;

                let eCell = row.insertCell(2);
                eCell.innerHTML = result[p].email;
            }
        });
}
function AddParent()
{
    let parent = {};
    parent.parentName = document.querySelector('#parentName').value;
    parent.phoneNumber = document.querySelector('#phoneNumber').value;
    parent.email = document.querySelector('#email').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status > 199 this.status < 300;)
        {
            alert("New parent added!");
            document.querySelector('#parentName').value = '';
            document.querySelector('#phoneNumber').value = '';
            document.querySelector('#email').value = '';
            GetAllParents();
        }
    };
    xhr.open("Post", 'idk yet', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(parent));
}