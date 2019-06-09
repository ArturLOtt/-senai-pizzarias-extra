import firebase from 'firebase'

const firebaseConfig = {
  apiKey: "AIzaSyBR_HhIEdWAUCNjyxEBzLmfr7WwURzsPuI",
  authDomain: "pronto-para-conectar.firebaseapp.com",
  databaseURL: "https://pronto-para-conectar.firebaseio.com",
  projectId: "pronto-para-conectar",
  storageBucket: "pronto-para-conectar.appspot.com",
  messagingSenderId: "628889803012",
  appId: "1:628889803012:web:d358ef0491cecb2b"
};

const auth = firebase.initializeApp(firebaseConfig);


// export const usuarioAutenticado = () => localStorage.getItem("usuario") !== null;


// export const parseJwt = () => {
//     var base64url = localStorage.getItem("usuario").split(".")[1]
//     var base64 = base64url.replace(/-/g, '+').replace(/_/g, '/')

//     return JSON.parse(window.atob(base64))
// }


export default auth
