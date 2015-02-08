(
    function (window, undifined) {
        $(document).ready(function () {
            $('#newWebUserTable').hide();
        });

        $(function () {
            // general
            $('#createWebUser').click(function (e){
                e.preventDefault();
                $('#newWebUserTable').show(1000);
            });
            $('#cancelCreateWebUser').click(function (e) {
                e.preventDefault();
                $('#newWebUserTable').hide(1000);
            });
            $('#saveCreateWebUser').click(function (e) {
                e.preventDefault();
                $('#newWebUserTable').hide(1000);
            });
        });

    }
)(window);