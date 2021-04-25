
class Mapa{
    constructor(map, lat, lng, id){
        this.map = map;
        this.lat = lat;
        this.lng = lng;
        this.id = id;
    }
}

const mp = new Mapa();

function mapar(){
   ////INICIO
let central = { lat: 18.489171348478873, lng: -69.92190543737865}

mp.map = new google.maps.Map(document.getElementById('map'),
{
    zoom: 15,
    center: central
}

);

/////FIN
}



function close(){
    document.getElementById('contenedor').className = "contenedor-modal-none";
}
function open() {
    document.getElementById('contenedor').className = "contenedor-modal";
}

function addMapa(){
   
    let marker2 = null;
mapar();
    mp.map.addListener("click", (e) => {
    
    let marker = new google.maps.Marker({
        position: e.latLng
    })
    
    if(marker2 != null){
        marker2.setMap(null)
    }
    marker.setMap(mp.map);
    marker2 = marker;
    let lat = document.getElementById('lat');
    let lng = document.getElementById('lng');



//40241350822
       mp.lat = lat.value = e.latLng.lat();
       mp.lng = lng.value = e.latLng.lng();
        console.log(lat.value);


    })
    }

function iMapa(datos){
        mapar();
        let central = { lat: 18.489171348478873, lng: -69.92190543737865}
        let array = [[18.49264765096979, -69.9471940767545], [18.489171348478873, -69.92190543737865] ]


    var z = JSON.parse(datos);
 
    z.forEach(x => {
        console.log("A ver "  + x.ID)
            let labels = x.ID;
        let marker = new google.maps.Marker({
            position: { lat: parseFloat(x.Lat), lng: parseFloat(x.Lng) },
            label: { text: x.Matricula, fontSize: "20px", fontWeight: "bold", color: 'white',   },
                map: mp.map
            })
        
            marker.addListener("click", (e) => {
                 mp.map.setZoom(16);
                mp.map.setCenter(marker.getPosition());
                Open(x);
                 
            }) 
        });


      

        
}

function Open(algo) {
    var x = document.getElementById('contenedor');

    if (x.className == "contenedor-modal-none") {
        x.className = "contenedor-modal"
    }

    document.getElementById('foto').setAttribute("src", algo.Foto);
    document.getElementById('marca').value = "MARCA: " + algo.Marca;
    document.getElementById('modelo').value ="MODELO: "+ algo.Modelo;
    document.getElementById('year').value = "AÑO: "+ algo.Year;
    document.getElementById('color').value = "COLOR: "+algo.Color;
    document.getElementById('matricula').value ="MATRICULA: "+ algo.Matricula;
    var z = document.getElementById('data');
    z.value = algo.ID;
    var event = new Event('change');
    z.dispatchEvent(event);



}

    function latitud(queseyo){
        
        let xd = mp.lat;

        return xd;

    }
    function longitud(queseyo){
        
        let xd = mp.lng;

        return xd;

    }
