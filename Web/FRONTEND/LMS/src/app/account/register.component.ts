import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ControlContainer, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';

import { AccountService, AlertService } from '@app/_services';
import { MustMatch } from '@app/_helpers';
import { Role } from '@app/_models';

@Component({ templateUrl: 'register.component.html' })
export class RegisterComponent implements OnInit {
    form: FormGroup;
    loading = false;
    submitted = false;
    driverLicense = false;

    constructor(
        private formBuilder: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private accountService: AccountService,
        private alertService: AlertService
    ) { }

    
    ngOnInit() {
        this.form = this.formBuilder.group({
            Fname: ['', Validators.required],
            Mname: ['', Validators.required],
            Lname: ['', Validators.required],
            Email: ['', [Validators.required, Validators.email]],
            Password: ['', [Validators.required, Validators.minLength(6)]],
            ConfirmPassword: ['', Validators.required],
            Phone_1: ['', Validators.required],
            NationalID : ['', Validators.required],
            Gender: ['', Validators.required],
            role: ['', Validators.required],
            LicenseID: [''],
            acceptTerms: [false, Validators.requiredTrue]
        }, {
            validator: MustMatch('Password', 'ConfirmPassword')
        });
    }

    // convenience getter for easy access to form fields
    get f() { return this.form.controls; }

    onSubmit() {
       
        this.submitted = true;

        // reset alerts on submit
        this.alertService.clear();

        // stop here if form is invalid
        if(this.form.invalid || ( this.form.controls['role'].value == Role.Driver && this.form.controls['LicenseID'].value == '')){
            this.form.controls['LicenseID'].setErrors(Validators.required);
            return;
        }

        this.loading = true;
        this.accountService.register(this.form.value)
            .pipe(first())
            .subscribe({
                next: () => {
                    this.alertService.success('Registration successful, please check your email for verification instructions', { keepAfterRouteChange: true });
                    this.router.navigate(['../login'], { relativeTo: this.route });
                },
                error: error => {
                    this.alertService.error(error);
                    this.loading = false;
                }
            });
        }
}