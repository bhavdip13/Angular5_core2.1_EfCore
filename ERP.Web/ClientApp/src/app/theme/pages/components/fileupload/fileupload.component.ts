
import { Component, OnInit, ViewEncapsulation, AfterViewInit, Inject } from '@angular/core';
import { HttpClient, HttpRequest, HttpEventType, HttpResponse } from '@angular/common/http'
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { ScriptLoaderService } from '../../../../_services/script-loader.service';
import { Helpers } from '../../../../helpers';
import { ToastyService } from 'ng2-toasty';

declare let Dropzone: any;
@Component({
    selector: 'fileupload',
    templateUrl: './fileupload.component.html',
		styleUrls: ['./fileupload.component.css'],
		encapsulation: ViewEncapsulation.None,
})

export class FileuploadComponent {
	private toastr: any;
	private toastrOptions: any;

	private defaultSuccess: string = "Success!";
	private defaultError: string = "Error!";
	private defaultInfo: string = "Info";

	  public progress: number;
    public message: string;
		constructor(private http: HttpClient, private _script: ScriptLoaderService, private toastyService: ToastyService) { }
		ngOnInit() {	

		}
		ngAfterViewInit() {
			this._script.loadScripts('fileupload',
				['../../../../../assets/demo/default/custom/components/forms/widgets/dropzone.js']);
			Dropzone._autoDiscoverFunction();
				this.toastyService.default('Your file has been uploaded!');
		}
  //  upload(files) {
  //      if (files.length === 0)
  //          return;

  //      const formData = new FormData();

  //      for (let file of files)
  //          formData.append(file.name, file);

  //      const uploadReq = new HttpRequest('POST', `api/upload`, formData, {
  //          reportProgress: true,
  //      });

  //      this.http.request(uploadReq).subscribe(event => {
  //          if (event.type === HttpEventType.UploadProgress)
  //              this.progress = Math.round(100 * event.loaded / event.total);
  //          else if (event.type === HttpEventType.Response)
  //              this.message = event.body.toString();
  //      });
		//}
		
}