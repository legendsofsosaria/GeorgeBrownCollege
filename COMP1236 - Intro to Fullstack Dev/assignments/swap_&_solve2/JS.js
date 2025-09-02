const cakes = [
    {
        name: "Chocolate Indulgence",
        description: "Rich chocolate cake with chocolate ganache.",
        allergies: "Dairy, Gluten",
        price: 35.00,
        image: "assets/choco.jpeg"
    },
    {
        name: "Vanilla Dream",
        description: "Classic vanilla cake with buttercream frosting.",
        allergies: "Dairy, Gluten",
        price: 30.00,
        image: "assets/VanillaDream.jpeg"
    },
    {
        name: "Strawberry Delight",
        description: "Strawberry cake with fresh strawberry filling.",
        allergies: "Dairy, Gluten",
        price: 40.00,
        image: "assets/Strawberry Delight.jpeg"
    },
    {
        name: "Red Velvet Bliss",
        description: "Classic red velvet cake with cream cheese frosting.",
        allergies: "Dairy, Gluten",
        price: 45.00,
        image: "assets/red.jpg"
    },
    {
        name: "Lemon Zest",
        description: "Refreshing lemon cake with lemon curd filling.",
        allergies: "Dairy, Gluten",
        price: 38.00,
        image: "assets/lemon.jpeg"
    },
    {
        name: "Carrot Cake Classic",
        description: "Moist carrot cake with walnuts and cream cheese frosting.",
        allergies: "Dairy, Gluten, Nuts",
        price: 42.00,
        image: "assets/carrot.jpg"
    }
];

const cakeList = document.getElementById("cake-list");
const selectedCakeList = document.getElementById("selected-cake-list");
const subtotalDisplay = document.getElementById("subtotal");
const modal = document.getElementById("full-image-modal");
const modalImg = document.getElementById("full-image");
const closeBtn = document.getElementsByClassName("close")[0];

let selectedCakes = [];

function renderCakes() {
    cakes.forEach((cake, index) => {
        const cakeItem = document.createElement("div");
        cakeItem.classList.add("cake-item");
        cakeItem.innerHTML = `
            <div class="checkbox-container">
                <input type="checkbox" class="cake-checkbox" data-index="${index}">
            </div>
            <img src="${cake.image}" alt="${cake.name}">
            <h3>${cake.name}</h3>
            <p>${cake.description}</p>
            <p>Allergies: ${cake.allergies}</p>
            <p>Price: $${cake.price.toFixed(2)}</p>
        `;

        const checkbox = cakeItem.querySelector(".cake-checkbox");
        checkbox.addEventListener("change", (event) => selectCake(index, event.target.checked, cakeItem));
        cakeItem.addEventListener("dblclick", () => showFullImage(cake.image));
        cakeList.appendChild(cakeItem);
    });
}

function selectCake(index, isChecked, cakeItem) {
    if (isChecked) {
        selectedCakes.push(index);
        cakeItem.classList.add("selected");
    } else {
        selectedCakes = selectedCakes.filter(i => i !== index);
        cakeItem.classList.remove("selected");
    }
    updateSelectedCakes();
}

function updateSelectedCakes() {
    selectedCakeList.innerHTML = "";
    let subtotal = 0;
    selectedCakes.forEach(index => {
        const cake = cakes[index];
        const listItem = document.createElement("li");
        listItem.textContent = `${cake.name} - $${cake.price.toFixed(2)}`;
        selectedCakeList.appendChild(listItem);
        subtotal += cake.price;
    });
    subtotalDisplay.textContent = `Subtotal: $${subtotal.toFixed(2)}`;
}

function showFullImage(imageSrc) {
    modal.style.display = "block";
    modalImg.src = imageSrc;
}

closeBtn.onclick = function() {
    modal.style.display = "none";
}

window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

renderCakes();