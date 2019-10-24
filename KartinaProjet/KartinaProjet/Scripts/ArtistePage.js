function afficher_cacher2(e,d,p) {
    document.getElementById('bouton_texte').innerHTML = (document.getElementById('bouton_texte').innerHTML == "Masquer le texte") ? "Afficher le texte" : "Masquer le texte";

    //text
    //presentation
    var elts = document.getElementsByClassName(e);

    //div
    //divPresentation
    var elts2 = document.getElementsByClassName(d);

    //points
    var elts3 = document.getElementsByClassName(p);


    var nbre_elts = elts.length;
    var nbre_elts2 = elts2.length;
    var nbre_elts3 = elts3.length;

    for (var i = 0; i < nbre_elts; i++) {
        //affichage des données qui depasse la div
        elts[i].style.overflow = (elts[i].style.overflow == "visible") ? "hidden" : "visible";

        elts[i].style.height = (elts[i].style.height == "auto") ? "100px" : "auto";
    }


    for (var i = 0; i < nbre_elts2; i++) {
        //hauteur de la div
        elts2[i].style.height = (elts2[i].style.height == "auto") ? "220px" : "auto";
    }


    for (var i = 0; i < nbre_elts3; i++) {
        //affichage des points
        elts3[i].style.display = (elts3[i].style.display == "none") ? "block" : "none";
    }
}
