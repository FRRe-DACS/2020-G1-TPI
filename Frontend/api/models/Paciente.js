/**
 * Paciente.js
 *
 * @description :: A model definition represents a database table/collection.
 * @docs        :: https://sailsjs.com/docs/concepts/models-and-orm/models
 */

module.exports = {

  attributes: {

    /*APIUserId:{
      type:'string',
    },*/
    Nombre:{
      type: 'string',
      required:true,
    },
    Apellido:{
      type: 'string',
      required:true
    },
    TipoDeDocumento:{ //Modelo Uno-Muchos
      model:'TipoDeDocumento',
    },
    NroDeDocumento:{
      type:'number',
    },
    FechaDeNacimiento:{
      type:'string',
    },
    Domicilio:{ //Modelo Uno-Uno
      collection:'Domicilio',
      via:'owner'
    },
    Telefono:{
      type:'string',
    },
    Sexo:{
      type:'string',
    },
    Correo:{
      type:'string',
    },
    //Relacion
    owner:{
      model:'FormularioParaAnalisis',
      unique:true
    }

  },

};

