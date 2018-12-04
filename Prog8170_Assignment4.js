function Validate_Form() {
    let name = document.getElementById('Name').value;
    let address = document.getElementById('Address').value;
    let city = document.getElementById('City').value;
    let phone = document.getElementById('Phone').value;
    let email = document.getElementById('Email').value;
    let make = document.getElementById('Make').value;
    let model = document.getElementById('Model').value;
    let year = document.getElementById('Year').value;
    let link = document.getElementById('link').href = "https://www.jdpower.com/cars/" + make + "/" + model + "/" + year;

    if ((name == "") || (!(isNaN(name)))) {
        alert("Enter valid Seller name");
    }
    else if (address == "") {
        alert("Enter Address");
    }
    else if ((city == "") || (!(isNaN(city)))) {
        alert("Enter valid City");
    }
    else if (frm.phone.value == "" || (isNaN(frm.phone.value)) || frm.phone.value.length < 10) {
        alert("Enter valid Phone Number");
    }
    else if (email == "") {
        alert("Enter valid Email-Address");
    }
    else if ((make == "") || (!(isNaN(make)))) {
        alert("Enter valid Vehicle Make");
    }

    else if ((model == "") || (!(isNaN(model)))) {
        alert("Enter valid Model");
    }
    else if ((year == "") || (isNaN(year))) {
        alert("Enter valid Year");
    }
    else {
        alert("Data Saved");


    }





}
function GenerateLink() {
    let make = document.getElementById('Make').value;
    let model = document.getElementById('Model').value;
    let year = document.getElementById('Year').value;
    let link = document.getElementById('link').href = "https://www.jdpower.com/cars/" + make + "/" + model + "/" + year;
    if ((make == "") || (!(isNaN(make)))) {
        alert("Enter valid Vehicle Make");
    }

    else if ((model == "") || (!(isNaN(model)))) {
        alert("Enter valid Model");
    }
    else if ((year == "") || (isNaN(year))) {
        alert("Enter valid Year");
    }
    else {


        document.getElementById('link').innerHTML = link;
    }

}