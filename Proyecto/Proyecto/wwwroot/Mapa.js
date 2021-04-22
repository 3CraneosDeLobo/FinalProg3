
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

function open(){
    document.getElementById('ventana').className = "contenedor-modal";
}

function close(){
    document.getElementById('ventana').className = "contenedor-modal-none";
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
       

        datos.forEach(x => {
            console.log("A ver " + x.id)
            let labels = x.id.toString();
            let marker = new google.maps.Marker({
                position: {lat: x.lat, lng: x.lng},
                label: labels,
                map: mp.map
            })
        
            marker.addListener("click", (e) => {
                 mp.map.setZoom(16);
                 mp.map.setCenter(marker.getPosition());
                 getId(x.id, x.cedula, x.name,x.lname,x.tel,x.fecha, x.provincia, x.v1, x.fechaV1, x.v2, x.fechaV2);
            }) 
        });


      

        
    }

    function latitud(queseyo){
        
        let xd = mp.lat;

        return xd;

    }
    function longitud(queseyo){
        
        let xd = mp.lng;

        return xd;

    }

    function getId(id,n1,n2,n3,n4,n5,n6,n7,n8,n9,n10){
          
document.getElementById('_id').value = id;
document.getElementById('_cedula').value = n1;
document.getElementById('_name').value = n2;
document.getElementById('_lname').value = n3;
document.getElementById('_tel').value = n4;
document.getElementById('_fecha').value = n5;
document.getElementById('_provincia').value = n6;
document.getElementById('_v1').value = n7;
document.getElementById('_fv1').value = n8;
document.getElementById('_v2').value = n9;
document.getElementById('_fv2').value = n10;


    }