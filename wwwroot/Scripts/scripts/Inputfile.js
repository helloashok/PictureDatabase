



    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
        $('#blah')
            .attr('src', e.target.result);
            };
           
    reader.readAsDataURL(input.files[0]);
        }
    }


function readPhoto(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#registerimgid')
                .attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);

    }
}
            function readLogo(input) {
                if (input.files && input.files[0]) {
                    var reader = new FileReader();

                    reader.onload = function (e) {
                        $('#image')
                            .attr('src', e.target.result);
                    };

                    reader.readAsDataURL(input.files[0]);
                }
                else {
                    $('#image').attr('src', "");
                }
            }






