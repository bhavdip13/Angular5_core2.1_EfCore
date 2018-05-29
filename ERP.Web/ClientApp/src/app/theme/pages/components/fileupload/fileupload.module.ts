import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { LayoutModule } from '../../../layouts/layout.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { DefaultComponent } from '../../default/default.component';
import { FileuploadComponent } from './fileupload.component';
const routes: Routes = [
    {
        "path": "",
        "component": DefaultComponent,
        "children": [
            {
                "path": "",
								"component": FileuploadComponent
            }
        ]
    }
];
@NgModule({
	imports: [
		CommonModule, RouterModule.forChild(routes), LayoutModule, FormsModule, HttpModule, ReactiveFormsModule
	], exports: [
		RouterModule
	], declarations: [
		FileuploadComponent
	]

})
export class FileuploadModule { }
