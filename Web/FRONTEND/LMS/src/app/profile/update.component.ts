import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';

import { AccountService, AlertService } from '@app/_services';
import { MustMatch } from '@app/_helpers';

@Component({ templateUrl: 'update.component.html' })
export class UpdateComponent implements OnInit {
    account = this.accountService.accountValue;
    form: FormGroup;
    id: string;
    isAddMode: boolean;
    loading = false;
    submitted = false;
    deleting = false;

    constructor(
        private formBuilder: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private accountService: AccountService,
        private alertService: AlertService
    ) { }

    ngOnInit() {
        this.id = this.account.id.toString();
        this.isAddMode = !this.id;
        this.form = this.formBuilder.group({
            fname: ['', Validators.required],
            mname: ['', Validators.required],
            lname: ['', Validators.required],
            gender: ['', Validators.required],
            relegion: ['', Validators.required],
            email: ['', [Validators.required, Validators.email]],
            role: ['', Validators.required],
            phone_1: ['', Validators.required],
            phone_2: [''],
            permanentAddress: ['', Validators.required],
            currentAddress: ['', Validators.required],
            nationalID: ['',Validators.required],
            password: ['', [Validators.minLength(6),this.isAddMode ? Validators.required : Validators.nullValidator]],
            confirmPassword: ['']
        }, {
            validator: MustMatch('password', 'confirmPassword')
        });
        if (!this.isAddMode) {
            this.accountService.getById(this.id)
                .pipe(first())
                .subscribe(x => this.form.patchValue(x));
        }
    }

    // convenience getter for easy access to form fields
    get f() { return this.form.controls; }

    onSubmit() {
        this.submitted = true;

        // reset alerts on submit
        this.alertService.clear();

        // stop here if form is invalid
        if (this.form.invalid) {
            return;
        }

        this.loading = true;
        this.accountService.update(this.account.id, this.form.value)
            .pipe(first())
            .subscribe({
                next: () => {
                    this.alertService.success('Update successful', { keepAfterRouteChange: true });
                    this.router.navigate(['../'], { relativeTo: this.route });
                },
                error: error => {
                    this.alertService.error(error);
                    this.loading = false;
                }
            });
    }

    onDelete() {
        if (confirm('Are you sure?')) {
            this.deleting = true;
            this.accountService.delete(this.account.id)
                .pipe(first())
                .subscribe(() => {
                    this.alertService.success('Account deleted successfully', { keepAfterRouteChange: true });
                });
        }
    }
}