namespace Rio.Membership {

    @Serenity.Decorators.registerClass()
    export class PublisherSignUpPanel extends Serenity.PropertyPanel<PublisherSignUpRequest, any> {

        protected getFormKey() { return PublisherSignUpForm.formKey; }

        private form: PublisherSignUpForm;

        constructor(container: JQuery) {
            super(container);

            this.form = new PublisherSignUpForm(this.idPrefix);

            this.form.ConfirmEmail.addValidationRule(this.uniqueName, e => {
                if (this.form.ConfirmEmail.value !== this.form.Email.value) {
                    return Texts.Validation.EmailConfirm;
                }
            });

            this.form.ConfirmPassword.addValidationRule(this.uniqueName, e => {
                if (this.form.ConfirmPassword.value !== this.form.Password.value) {
                    return Q.text('Validation.PasswordConfirm');
                }
            });

            this.byId('SubmitButton').click(e => {
                e.preventDefault();

                if (!this.validateForm()) {
                    return;
                }

                Q.serviceCall({
                    url: Q.resolveUrl('~/Publisher/SignUp'),
                    request: {
                        Organization: this.form.Organization.value,
                        Name: this.form.DisplayName.value,
                        Email: this.form.Email.value,
                        Password: this.form.Password.value
                    },
                    onSuccess: response => {
                        Q.information(Q.text('Forms.Membership.SignUp.Success'), () => {
                            window.location.href = Q.resolveUrl('~/');
                        });
                    }
                });

            });
        }
    }
}