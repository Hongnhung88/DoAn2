/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */


CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    //config.language = 'fr';
    //// config.uiColor = '#AADC6E';
   
    config.basicEntities = false;
    config.entities_latin = true;
    editor.config.syntaxhighlight_lang = 'csharp';
    editor.config.syntaxhighlight_hideControls = true;
    
    //editor.config.language = 'vi';
    config.language = 'vi';
    config.contentsLanguage = 'vi';
    

    editor.config.filebrowserBrowseUrl = '/Assets/Admin/js/plugins/ckfinder/ckfinder.html';
    editor.config.filebrowserImageBrowseUrl = '/Assets/Admin/js/plugins/ckfinder.html?Type=Images';
    editor.config.filebrowserFlashBrowseUrl = '/Assets/Admin/js/plugins/ckfinder.html?Type=Flash';
    editor.config.filebrowserUploadUrl = '/Assets/Admin/js/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    editor.config.filebrowserImageUploadUrl = '/Data';
    editor.config.filebrowserFlashUploadUrl = '/Assets/Admin/js/plugins//ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';

    CKFinder.setupCKEditor(null, '/Assets/Admin/js/plugins/ckfinder/');

};
