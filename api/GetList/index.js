module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    context.res = {
        body: ["Jarod", "Hannah", "Kevin", "Mitch"]
    }
};

//module.exports = async function (context, req) {
//    context.log('JavaScript HTTP trigger function processed a request.');

//    var category = context.bindingData.category;
//    var id = context.bindingData.id;
//    context.res = {
//        body: [category, id]
//    }
//};