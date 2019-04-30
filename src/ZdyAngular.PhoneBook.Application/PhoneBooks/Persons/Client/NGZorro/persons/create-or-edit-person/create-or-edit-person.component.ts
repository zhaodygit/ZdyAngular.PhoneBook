
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdatePersonInput,PersonEditDto, PersonServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-person',
  templateUrl: './create-or-edit-person.component.html',
  styleUrls:[
	'create-or-edit-person.component.less'
  ],
})

export class CreateOrEditPersonComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: PersonEditDto=new PersonEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _personService: PersonServiceProxy
	) {
		super(injector);
    }

    ngOnInit() :void{
		this.init();
    }


    /**
    * 初始化方法
    */
    init(): void {
		this._personService.getForEdit(this.id).subscribe(result => {
			this.entity = result.person;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdatePersonInput();
		input.person = this.entity;

		this.saving = true;

		this._personService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }
}
