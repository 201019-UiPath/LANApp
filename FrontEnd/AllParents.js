
function GetAllParents() {
    
    fetch('https://localhost:44331/parent/get/')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#parents tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#parents tbody');

        for(let i = 0; i < result.length; ++i) {
            let row = table.insertRow(table.rows.length);

            let nameCell = row.insertCell(0);
            nameCell.innerHTML = result[i].name;

            let phoneCell = row.insertCell(1);
            phoneCell.innerHTML = result[i].phoneNumber;

            let emailCell = row.insertCell(2);
            emailCell.innerHTML = result[i].emailAddress;

            let addCell = row.insertCell(3);
            let btn = document.createElement('input');
            btn.type = 'button';
            btn.id = result[i].id;
            btn.value = 'Select';

            btn.onclick = function GetKids() {
                window.location = "ParentDetails.html";
            }      

            addCell.appendChild(btn);

        }
    });
}

function AddParent()
{
    let parent = {};
    parent.Name = document.querySelector('#parentName').value;
    parent.PhoneNumber = document.querySelector('#phoneNumber').value;
    parent.EmailAddress = document.querySelector('#email').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("New parent added!");
            document.querySelector('#parentName').value = '';
            document.querySelector('#phoneNumber').value = '';
            document.querySelector('#email').value = '';
            GetAllParents();
        }
    };

    xhr.open("Post", 'https://localhost:44331/parent/add/', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(parent));
}